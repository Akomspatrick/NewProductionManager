using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateTesterCommand(TesterCreateRequestDTO  CreateTesterDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}