using Pets.Application.Input.Commands.VaccineContext;
using Pets.Application.Input.Handlers.Contracts;
using Pets.Application.Output.Results;
using Pets.Application.Output.Results.Contracts;
using Pets.Application.Repositories.VaccineContext;
using Pets.Domain.Entities.VaccineContext;
using Pets.Domain.Notifications;

namespace Pets.Application.Input.Handlers.VaccineContext
{
    public class InsertCategoriaHandler : IHandlerBase<InsertCategoriaCommand>
    {
        private readonly ICategoriaRepository _Repository;

        public InsertCategoriaHandler(ICategoriaRepository repository)
        {
            _Repository = repository;
        }
        public IResultBase Handle(InsertCategoriaCommand command)
        {
            var categoria = new Categoria(command.Descricao);
            Result result;

            if (categoria.Validation())
            {
                try
                {
                    _Repository.InsertCategoria(categoria);
                    result = new Result(201, $"Categoria {categoria.Descricao} gravada com sucesso", true);
                    return result;
                }
                catch (Exception ex)
                {

                    result = new Result(500, $"Erro interno no servidor, detalhes: {ex.Message}", false);
                }
            }
            result = new Result(400, $"Falha ao gravar Categoria{categoria.Descricao}", false);
            result.SetNotifications(categoria.Notifications as List<Notification>);
            return result;
        }
    }
}
