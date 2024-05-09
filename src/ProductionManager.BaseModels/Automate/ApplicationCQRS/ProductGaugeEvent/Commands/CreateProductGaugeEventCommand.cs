using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductGaugeEventCommand(ProductGaugeEventCreateRequestDTO  CreateProductGaugeEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}