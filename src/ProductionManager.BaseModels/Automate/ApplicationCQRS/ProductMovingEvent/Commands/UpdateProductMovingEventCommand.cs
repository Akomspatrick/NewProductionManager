using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductMovingEventCommand(ProductMovingEventUpdateRequestDTO  UpdateProductMovingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}