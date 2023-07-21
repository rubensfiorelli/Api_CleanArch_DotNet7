using Pets.Application.Input.Commands.Contracts;

namespace Pets.Application.Input.Commands.VaccineContext
{
    public class InsertVaccinceCommand : ICommandBase
    {
        public Guid CategoriaId { get; set; }
        public Guid PetId { get; set; }
        public string Descricao { get; set; }
    }
}
