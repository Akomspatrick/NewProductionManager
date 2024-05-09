using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductMovingEventCommand(ProductMovingEventDeleteRequestDTO  DeleteProductMovingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}