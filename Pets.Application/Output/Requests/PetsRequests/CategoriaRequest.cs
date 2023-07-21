using Pets.Application.Output.DTOs;
using Pets.Application.Output.Results;

namespace Pets.Application.Output.Requests.PetsRequests
{
    public class CategoriaRequest
    {
        public Result? Result { get; set; }
        public ICollection<CategoriaDTO>? Categorias { get; set; }
    }
}
