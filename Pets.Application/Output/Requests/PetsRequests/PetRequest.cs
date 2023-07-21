using Pets.Application.Output.DTOs;
using Pets.Application.Output.Requests.Contracts;
using Pets.Application.Output.Results;

namespace Pets.Application.Output.Requests.PetsRequests
{
    public class PetRequest : IRequestBase
    {
        public Result? Result { get; set; }
        public ICollection<PetDTO>? Pets { get; set; }

    }
}
