using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductGaugeEventCommand(ProductGaugeEventDeleteRequestDTO  DeleteProductGaugeEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}