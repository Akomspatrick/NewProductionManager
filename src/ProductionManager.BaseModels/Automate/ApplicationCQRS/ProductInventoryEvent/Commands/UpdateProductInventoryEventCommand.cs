using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductInventoryEventCommand(ProductInventoryEventUpdateRequestDTO  UpdateProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}