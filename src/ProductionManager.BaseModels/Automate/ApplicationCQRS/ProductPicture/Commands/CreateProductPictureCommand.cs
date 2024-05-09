using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductPictureCommand(ProductPictureCreateRequestDTO  CreateProductPictureDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}