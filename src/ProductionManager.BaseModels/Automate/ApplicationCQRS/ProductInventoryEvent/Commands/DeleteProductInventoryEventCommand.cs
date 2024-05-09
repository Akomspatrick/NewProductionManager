using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductInventoryEventCommand(ProductInventoryEventDeleteRequestDTO  DeleteProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}