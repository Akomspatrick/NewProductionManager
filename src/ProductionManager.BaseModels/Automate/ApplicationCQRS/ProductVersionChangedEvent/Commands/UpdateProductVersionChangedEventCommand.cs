using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductVersionChangedEventCommand(ProductVersionChangedEventUpdateRequestDTO  UpdateProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}