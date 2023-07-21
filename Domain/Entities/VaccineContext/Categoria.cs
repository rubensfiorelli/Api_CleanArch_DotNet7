using Domain.Validations;
using Pets.Domain.Validations.Contracts;

namespace Pets.Domain.Entities.VaccineContext
{
    public sealed class Categoria : BaseEntity, IContract
    {
        public Categoria(string descricao) : base(descricao)
        {
        }

        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Categoria>()
                .GuidIsValid(Id, "Id invávlido", "Guid");


            return contracts.IsValid();
        }
    }
}
