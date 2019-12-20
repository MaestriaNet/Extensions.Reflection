using System.Threading.Tasks;
using Maestria.Reflection.Extensions.Test.Interfaces;

namespace Maestria.Reflection.Extensions.Test.Models
{
    public class PaisCommandHandler : CommandHandler, IHandler<PaisSaveCommand, PaisDomain>
    {
        public Task<PaisDomain> HandlerAsync(PaisSaveCommand message)
        {
            return null;
        }
    }
}
