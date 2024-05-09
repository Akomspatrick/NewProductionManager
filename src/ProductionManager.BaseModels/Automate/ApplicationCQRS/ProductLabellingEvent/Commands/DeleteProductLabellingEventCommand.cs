using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductLabellingEventCommand(ProductLabellingEventDeleteRequestDTO  DeleteProductLabellingEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}