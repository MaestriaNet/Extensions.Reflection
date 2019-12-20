using System.Threading.Tasks;

namespace Maestria.Reflection.Extensions.Test.Interfaces
{
    public interface IHandler<in TCommand>
    {
        Task HandlerAsync(TCommand message);
    }

    public interface IHandler<in TCommand, TResult>
    {
        Task<TResult> HandlerAsync(TCommand message);
    }
}