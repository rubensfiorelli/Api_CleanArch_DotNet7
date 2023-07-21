using Pets.Application.Input.Commands.VaccineContext;
using Pets.Application.Input.Handlers.Contracts;
using Pets.Application.Output.Results;
using Pets.Application.Output.Results.Contracts;
using Pets.Application.Repositories.VaccineContext;
using Pets.Domain.Entities.VaccineContext;
using Pets.Domain.Notifications;

namespace Pets.Application.Input.Handlers.VaccineContext
{
    public class InsertVaccineHandler : IHandlerBase<InsertVaccinceCommand>
    {
        private readonly IVaccineRepository _Repository;

        public InsertVaccineHandler(IVaccineRepository repository)
        {
            _Repository = repository;
        }
        public IResultBase Handle(InsertVaccinceCommand command)
        {
            var vaccine = new Vaccine(command.Descricao, command.CategoriaId, command.PetId);
            Result result;

            if (vaccine.Validation())
            {
                try
                {
                    _Repository.InsertVaccine(vaccine);
                    result = new Result(201, $"Vacina gravada com sucesso", true);
                    return result;
                }
                catch (Exception ex)
                {

                    result = new Result(500, $"Erro interno no servidor, detalhes: {ex.Message}", false);
                }
            }
            result = new Result(400, $"Falha ao gravar vacina", false);
            result.SetNotifications(vaccine.Notifications as List<Notification>);
            return result;
        }
    }
}
