using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductSealingEventCommand(ProductSealingEventDeleteRequestDTO  DeleteProductSealingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}