using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductVersionChangedEventCommand(ProductVersionChangedEventDeleteRequestDTO  DeleteProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}