using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateTesterCommand(TesterUpdateRequestDTO  UpdateTesterDTO) :  IRequest<Either<GeneralFailure, int>>;
}