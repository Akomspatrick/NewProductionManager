using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductReceptionEventCommand(ProductReceptionEventDeleteRequestDTO  DeleteProductReceptionEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}