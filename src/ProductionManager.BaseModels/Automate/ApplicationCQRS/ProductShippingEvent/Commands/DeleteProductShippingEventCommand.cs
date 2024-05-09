using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductShippingEventCommand(ProductShippingEventDeleteRequestDTO  DeleteProductShippingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}