using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductShippingEventCommand(ProductShippingEventCreateRequestDTO  CreateProductShippingEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}