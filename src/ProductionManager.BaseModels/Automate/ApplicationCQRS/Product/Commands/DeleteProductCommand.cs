using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductCommand(ProductDeleteRequestDTO  DeleteProductDTO) :  IRequest<Either<GeneralFailure, int>>;
}