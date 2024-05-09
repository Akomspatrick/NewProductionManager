using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductCablingEventCommand(ProductCablingEventUpdateRequestDTO  UpdateProductCablingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}