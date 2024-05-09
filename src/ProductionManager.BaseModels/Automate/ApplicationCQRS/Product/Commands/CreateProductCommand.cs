using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductCommand(ProductCreateRequestDTO  CreateProductDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}