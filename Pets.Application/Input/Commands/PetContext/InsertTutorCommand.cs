using Pets.Application.Input.Commands.Contracts;
using Pets.Domain.ValueObjects;

namespace Pets.Application.Input.Commands.PetContext
{
    public class InsertTutorCommand : ICommandBase
    {
        public Nome Nome { get; set; }
        public Documento Documento { get; set; }
        public string Email { get; set; }
    }
}
