using System;
using System.Linq;

namespace Maestria.Reflection.Extensions
{
    internal static class IsInheritedOrImplementsExtensions
    {
        /// <summary>
        /// Check if child inherited or implements parent. This method support types with generic data types declaration and check inheritance of generic types too.
        /// </summary>
        /// <param name="child"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        internal static bool IsInheritedOrImplements(Type child, Type parent)
        {
            // ATENÇÃO: SE FOR ALTERAR ALGO AQUI, EXECUTE O PROJETO DE TESTE UNITÁRIO DO FRAMEWORK!!!
            if (child == parent)
                return true;

            if (child.IsGenericType && parent.IsGenericType && child.IsGenericTypeArgumentsInheritedsFrom(parent))
                return true;

            parent = ResolveGenericTypeDefinition(parent);

            var currentChild = child.IsGenericType
                ? child.GetGenericTypeDefinition()
                : child;

            while (currentChild != typeof(object))
            {
                if (parent == currentChild || HasAnyInterfaces(parent, currentChild))
                    return true;

                currentChild = currentChild.BaseType != null
                               && currentChild.BaseType.IsGenericType
                    ? currentChild.BaseType.GetGenericTypeDefinition()
                    : currentChild.BaseType;

                if (currentChild == null)
                    return false;
            }

            return false;
        }

        /// <summary>
        /// Check if child generics data types is inherited or implements generics from parent respecting order of args
        /// </summary>
        /// <param name="child"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private static bool IsGenericTypeArgumentsInheritedsFrom(this Type child, Type parent)
        {
            // ATENÇÃO: SE FOR ALTERAR ALGO AQUI, EXECUET O PROJETO DE TESTE UNITÁRIO DO FRAMEWORK!!!
            if (parent.GenericTypeArguments.Length > 0 &&
                parent.GenericTypeArguments.Length == child.GenericTypeArguments.Length)
            {
                for (var i = 0; i < parent.GenericTypeArguments.Length; i++)
                {
                    if (!parent.GenericTypeArguments[i].IsAssignableFrom(child.GenericTypeArguments[i]))
                        return false;
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if types implements an interface
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <returns></returns>
        private static bool HasAnyInterfaces(Type parent, Type child)
        {
            // ATENÇÃO: SE FOR ALTERAR ALGO AQUI, EXECUET O PROJETO DE TESTE UNITÁRIO DO FRAMEWORK!!!
            return child.GetInterfaces()
                .Any(childInterface =>
                {
                    if (parent.IsAssignableFrom(childInterface))
                        return true;

                    if (childInterface.IsGenericTypeArgumentsInheritedsFrom(parent))
                        return true;

                    var currentInterface = childInterface.IsGenericType
                        ? childInterface.GetGenericTypeDefinition()
                        : childInterface;

                    return currentInterface == parent;
                });
        }

        /// <summary>
        /// typeof(List<int>)                            = System.Collections.Generic.List`1[System.Int32]
        /// typeof(List<int>).GetGenericTypeDefinition() = System.Collections.Generic.List`1[T]
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static Type ResolveGenericTypeDefinition(Type type)
        {
            // ATENÇÃO: SE FOR ALTERAR ALGO AQUI, EXECUET O PROJETO DE TESTE UNITÁRIO DO FRAMEWORK!!!

            // ReSharper disable once ReplaceWithSingleAssignment.True
            var shouldUseGenericType = true;
            if (type.IsGenericType && type.GetGenericTypeDefinition() != type)
                shouldUseGenericType = false;

            if (type.IsGenericType && shouldUseGenericType)
                type = type.GetGenericTypeDefinition();
            return type;
        }
    }
}