using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductWiringEventCommand(ProductWiringEventCreateRequestDTO  CreateProductWiringEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}