using Pets.Application.Output.Requests.PetsRequests;
using Pets.Application.Output.Results.Contracts;
using Pets.Domain.Entities.PetContext;

namespace Pets.Application.Repositories.PetContext
{
    public interface ITutorRepository
    {
        void InsertTutor(Tutor tutor);
        Task<TutorRequest> SelectTutorByDocumentoAsync(string documento);
        Task<TutorRequest> SelectTutorByEmailAsync(string email);
        IResultBase DeleteById(Guid tutorId);

    }
}
