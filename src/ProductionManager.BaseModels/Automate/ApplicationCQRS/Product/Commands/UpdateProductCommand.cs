using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductCommand(ProductUpdateRequestDTO  UpdateProductDTO) :  IRequest<Either<GeneralFailure, int>>;
}