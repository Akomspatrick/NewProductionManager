using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductAdditionalInfoCommand(ProductAdditionalInfoUpdateRequestDTO  UpdateProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, int>>;
}