using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductReceptionEventCommand(ProductReceptionEventUpdateRequestDTO  UpdateProductReceptionEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}