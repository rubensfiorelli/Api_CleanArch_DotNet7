using Pets.Application.Input.Commands.Contracts;
using Pets.Application.Output.Results.Contracts;

namespace Pets.Application.Input.Handlers.Contracts
{
    public interface IHandlerBase<in T> where T : ICommandBase
    {
        IResultBase Handle(T command);
    }
}
