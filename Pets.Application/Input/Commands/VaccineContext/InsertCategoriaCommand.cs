using Pets.Application.Input.Commands.Contracts;

namespace Pets.Application.Input.Commands.VaccineContext
{
    public class InsertCategoriaCommand : ICommandBase
    {
        public string Descricao { get; set; }
    }
}
