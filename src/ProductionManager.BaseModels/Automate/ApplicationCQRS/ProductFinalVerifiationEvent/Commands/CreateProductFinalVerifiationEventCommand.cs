using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductFinalVerifiationEventCommand(ProductFinalVerifiationEventCreateRequestDTO  CreateProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}