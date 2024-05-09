using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductVersionChangedEventCommand(ProductVersionChangedEventCreateRequestDTO  CreateProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}