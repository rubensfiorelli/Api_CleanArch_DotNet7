using Pets.Application.Output.Requests.PetsRequests;
using Pets.Domain.Entities.PetContext;

namespace Pets.Application.Repositories.PetContext
{
    public interface IPetRepository
    {
        void InsertPet(Pet pet);
        Task<PetRequest> SelectPetsTutorIdAsync(Guid id);

    }
}
