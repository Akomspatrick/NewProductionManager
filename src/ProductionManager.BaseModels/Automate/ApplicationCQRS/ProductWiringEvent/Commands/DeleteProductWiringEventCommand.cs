using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductWiringEventCommand(ProductWiringEventDeleteRequestDTO  DeleteProductWiringEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}