using Pets.Application.Input.Commands.PetContext;
using Pets.Application.Input.Handlers.Contracts;
using Pets.Application.Output.Results;
using Pets.Application.Output.Results.Contracts;
using Pets.Application.Repositories.PetContext;
using Pets.Domain.Entities.PetContext;
using Pets.Domain.Notifications;

namespace Pets.Application.Input.Handlers.PetContext
{
    public class InsertPetHandler : IHandlerBase<InsertPetCommand>
    {
        private readonly IPetRepository _Repository;

        public InsertPetHandler(IPetRepository repository)
        {
            _Repository = repository;
        }
        public IResultBase Handle(InsertPetCommand command)
        {
            var pet = new Pet(command.Nome, command.Identificacao);
            Result result;

            if (pet.Validation())
            {
                try
                {
                    _Repository.InsertPet(pet);
                    result = new Result(201, $"Pet {pet.Nome.UltimoNome} gravado com sucesso", true);
                    return result;
                }
                catch (Exception ex)
                {

                    result = new Result(500, $"Erro interno no servidor, detalhes: {ex.Message}", false);
                }
            }
            result = new Result(400, $"Falha ao gravar Pet{pet.Nome.UltimoNome}", false);
            result.SetNotifications(pet.Notifications as List<Notification>);
            return result;
        }
    }
}
