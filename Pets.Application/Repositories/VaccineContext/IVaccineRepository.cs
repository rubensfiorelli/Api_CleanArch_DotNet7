using Pets.Domain.Entities.VaccineContext;

namespace Pets.Application.Repositories.VaccineContext
{
    public interface IVaccineRepository
    {
        void InsertVaccine(Vaccine vaccine);
    }
}
