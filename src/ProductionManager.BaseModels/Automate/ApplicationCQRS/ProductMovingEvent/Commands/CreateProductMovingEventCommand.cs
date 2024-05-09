using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductMovingEventCommand(ProductMovingEventCreateRequestDTO  CreateProductMovingEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}