using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductAdditionalInfoCommand(ProductAdditionalInfoCreateRequestDTO  CreateProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}