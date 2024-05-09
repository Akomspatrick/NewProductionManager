using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductInventoryEventCommand(ProductInventoryEventCreateRequestDTO  CreateProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}