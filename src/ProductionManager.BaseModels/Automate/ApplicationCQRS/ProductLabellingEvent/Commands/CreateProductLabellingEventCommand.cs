using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductLabellingEventCommand(ProductLabellingEventCreateRequestDTO  CreateProductLabellingEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}