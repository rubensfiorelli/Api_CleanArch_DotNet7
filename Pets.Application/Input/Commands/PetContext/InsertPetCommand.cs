using Pets.Application.Input.Commands.Contracts;
using Pets.Domain.ValueObjects;

namespace Pets.Application.Input.Commands.PetContext
{
    public class InsertPetCommand : ICommandBase
    {
        public Nome Nome { get; set; }
        public int Identificacao { get; set; }
        public Guid TutorId { get; set; }

    }
}
