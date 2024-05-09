using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductSurfacePreparationEventCommand(ProductSurfacePreparationEventCreateRequestDTO  CreateProductSurfacePreparationEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}