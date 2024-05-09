using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductFinalVerifiationEventCommand(ProductFinalVerifiationEventDeleteRequestDTO  DeleteProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}