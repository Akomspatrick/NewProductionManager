using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductWiringEventCommand(ProductWiringEventUpdateRequestDTO  UpdateProductWiringEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}