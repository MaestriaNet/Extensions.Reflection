using System.Threading.Tasks;
using Maestria.Extensions.Reflection.Test.Interfaces;

namespace Maestria.Extensions.Reflection.Test.Models
{
    public class PaisCommandHandler : CommandHandler, IHandler<PaisSaveCommand, PaisDomain>
    {
        public Task<PaisDomain> HandlerAsync(PaisSaveCommand message)
        {
            return null;
        }
    }
}
