using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductCablingEventCommand(ProductCablingEventCreateRequestDTO  CreateProductCablingEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}