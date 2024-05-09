using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductAdditionalInfoCommand(ProductAdditionalInfoDeleteRequestDTO  DeleteProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, int>>;
}