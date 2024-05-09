using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductFinalVerifiationEventCommand(ProductFinalVerifiationEventUpdateRequestDTO  UpdateProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}