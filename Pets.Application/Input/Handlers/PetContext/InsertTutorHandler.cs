using Pets.Application.Input.Commands.PetContext;
using Pets.Application.Input.Handlers.Contracts;
using Pets.Application.Output.Results;
using Pets.Application.Output.Results.Contracts;
using Pets.Application.Repositories.PetContext;
using Pets.Domain.Entities.PetContext;
using Pets.Domain.Notifications;

namespace Pets.Application.Input.Handlers.PetContext
{
    public class InsertTutorHandler : IHandlerBase<InsertTutorCommand>
    {
        private readonly ITutorRepository _Repository;

        public InsertTutorHandler(ITutorRepository repository)
        {
            _Repository = repository;
        }

        public IResultBase Handle(InsertTutorCommand command)
        {
            var tutor = new Tutor(command.Nome, command.Email, command.Documento);
            Result result;

            if (tutor.Validation())
            {
                try
                {
                    _Repository.InsertTutor(tutor);
                    result = new Result(201, $"Tutor {tutor.Nome.UltimoNome} gravado com sucesso", true);
                    return result;
                }
                catch (Exception ex)
                {

                    result = new Result(500, $"Erro interno no servidor, detalhes: {ex.Message}", false);
                }
            }
            result = new Result(400, $"Falha ao gravar Tutor{tutor.Nome.UltimoNome}", false);
            result.SetNotifications(tutor.Notifications as List<Notification>);
            return result;
        }
    }
}
