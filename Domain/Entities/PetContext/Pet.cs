using Domain.Validations;
using Pets.Domain.Validations.Contracts;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public sealed class Pet : BaseEntity, IContract
    {
        public Pet(Nome nome, int identificacao) : base(nome)
        {
            Identificacao = identificacao;
        }

        public int Identificacao { get; private set; }

        public void SetIdentificacao(int identificacao)
        {
            Identificacao = identificacao;
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Pet>()
                .PrimeiroNomeOK(Nome, 20, 4, "O primeiro nome deve ter entre 4 e 20 caracteres", "Nome");


            return contracts.IsValid();
        }
    }
}
