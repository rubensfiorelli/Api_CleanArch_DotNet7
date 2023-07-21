using Pets.Application.Output.Requests.PetsRequests;
using Pets.Application.Output.Results.Contracts;
using Pets.Domain.Entities.VaccineContext;

namespace Pets.Application.Repositories.VaccineContext
{
    public interface ICategoriaRepository
    {
        void InsertCategoria(Categoria categoria);
        IResultBase DeleteCategira(Guid categoriaId);
        Task<CategoriaRequest> SelectAllCategoriaAsync();

    }
}
