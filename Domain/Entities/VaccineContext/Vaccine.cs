using Domain.Validations;
using Pets.Domain.Validations.Contracts;

namespace Pets.Domain.Entities.VaccineContext
{
    public sealed class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string descricao, Guid categoriaId, Guid petId) : base(descricao)
        {
            CategoriaId = categoriaId;
            PetId = petId;
        }

        public Guid CategoriaId { get; private set; }
        public Guid PetId { get; private set; }


        public override void SetDescricao(string descricao)
        {
            base.SetDescricao(descricao);
        }

        public override bool Validation()
        {
            var contracts = new ContractValidations<Vaccine>()
               .GuidIsValid(Id, "Id invávlido", "Guid");


            return contracts.IsValid();
        }
    }
}
