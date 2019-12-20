using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Maestria.Reflection.Extensions
{
    public static class ReflectionExtensions
    {
        #region CreateInstance
        
        /// <summary>
        /// Create instance of object using constructor of data type arguments
        /// </summary>
        /// <param name="type">Class type to create new instance</param>
        /// <param name="parameters">Parameters to instantiate class</param>
        /// <returns>New instance</returns>
        public static object CreateInstance(this Type type, params object[] parameters)
        {
            var argsDataTypes = new Type[parameters.Length];
            for (var i = 0; i < parameters.Length; i++)
                argsDataTypes[i] = parameters[i].GetType();

            var constructorInfo = type.GetConstructor(argsDataTypes);

            if (constructorInfo != null)
                return Activator.CreateInstance(type, parameters);

            var strDataTypes = "";
            for (var i = 0; i < argsDataTypes.Length; i++)
                strDataTypes += $"{i + 1} - {argsDataTypes[i].FullName}\n";
            strDataTypes = strDataTypes.Trim();

            throw new NotImplementedException(
                $"Not implemented construtor at class '{type.FullName}' with the parameters: {strDataTypes}");
        }
        
        /// <summary>
        /// Create instance of object using constructor of data type arguments
        /// </summary>
        /// <typeparam name="T">lass type to create new instance</typeparam>
        /// <param name="parameters">Parameters to instantiate class</param>
        /// <returns>New instance</returns>
        public static T CreateInstance<T>(params object[] parameters) => (T) CreateInstance(typeof(T), parameters);
        
        #endregion
        
        #region HasConstructor
        
        public static bool HasConstructor(this Type type, params Type[] parametersTypes) =>
            type.GetConstructor(parametersTypes) != null;
        
        public static bool HasConstructor(this Type type, params object[] parameters)
        {
            var parametersTypes = new Type[parameters.Length];
            for (var i = 0; i < parameters.Length; i++)
                parametersTypes[i] = parameters[i].GetType();

            return HasConstructor(type, parametersTypes);
        }

        public static bool HasConstructor<T>(params Type[] parametersTypes) =>
            HasConstructor(typeof(T), parametersTypes);

        public static bool HasConstructor<T>(params object[] parameters) => HasConstructor(typeof(T), parameters);
        
        #endregion

        #region PropertyExist
        
        public static bool PropertyExist(this Type type, string name) =>
            type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public) != null;
        
        public static bool PropertyExist(object instance, string name)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));
            return PropertyExist(instance.GetType(), name);
        }
        
        public static bool PropertyExist<T>(string name) => PropertyExist(typeof(T), name);
        
        #endregion

        #region Get / Set PropertyValue
        
        public static object GetPropertyValue(object instance, string name)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            var propInfo = instance.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
            if (propInfo == null)
                throw new ArgumentException(
                    string.Format("Property '{0}' not found into type '{1}'.", name, instance.GetType().FullName),
                    nameof(name));

            return propInfo.GetValue(instance);
        }
        
        public static T GetPropertyValue<T>(object instance, string name) =>
            (T) GetPropertyValue(instance, name);
        
        public static void SetPropertyValue(object instance, string name, object value)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            var propInfo = instance.GetType().GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
            if (propInfo == null)
                throw new ArgumentException(
                    string.Format("Property '{0}' not found into type '{1}'.", name, instance.GetType().FullName),
                    nameof(name));

            propInfo.SetValue(instance, value);
        }

        #endregion
        
        #region InvokeMethod

        public static object InvokeMethod(object instance, string name, params object[] parameters)
        {
            if (instance == null)
                throw new ArgumentNullException(nameof(instance));

            var methodInfo = instance.GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.Public);
            if (methodInfo == null)
                throw new ArgumentException(
                    string.Format("Method '{0}' not found into type '{1}'.", name, instance.GetType().FullName),
                    nameof(name));

            return methodInfo.Invoke(instance, parameters);
        }

        public static T InvokeMethod<T>(object instance, string name, params object[] parameters) =>
            (T) InvokeMethod(instance, name, parameters);
        
        #endregion
        
        #region GetTaskResult

        public static object GetResult(this Task task)
        {
            if (task != null && task.GetType().IsInheritedOrImplements(typeof(Task<>)))
                return task
                    .GetType()
                    .GetProperty(nameof(Task<object>.Result))
                    ?.GetValue(task);
            return null;
        }

        public static object GetTaskResult(object task) => GetResult(task as Task);

        #endregion

        #region Others
        
        public static bool IsInheritedOrImplements(this Type child, Type parent) =>
            IsInheritedOrImplementsExtensions.IsInheritedOrImplements(child, parent);
        
        #endregion
    }
}