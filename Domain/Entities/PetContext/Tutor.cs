using Domain.Validations;
using Pets.Domain.Validations.Contracts;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public sealed class Tutor : BaseEntity, IContract
    {
        public Tutor(Nome nome, string email, Documento documento) : base(nome)
        {
            Email = email;
            Documento = documento;

        }

        public string Email { get; private set; }
        public Documento Documento { get; private set; }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Tutor>()
                 .PrimeiroNomeOK(Nome, 20, 5, "O primeiro nome deve ter entre 4 e 20 caracteres", "Primeiro Nome")
                 .PrimeiroNomeOK(Nome, 40, 5, "O ultimo nome deve ter entre 5 e 40 caracteres", "Ultimo Nome")
                 .EmailIsValid(Email, "Email em branco", nameof(Email));


            return contracts.IsValid();
        }
    }
}
