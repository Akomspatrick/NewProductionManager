using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductSurfacePreparationEventCommand(ProductSurfacePreparationEventDeleteRequestDTO  DeleteProductSurfacePreparationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}