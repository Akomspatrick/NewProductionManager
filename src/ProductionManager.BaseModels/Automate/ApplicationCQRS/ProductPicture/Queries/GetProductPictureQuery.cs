using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductPictureQuery(ProductPictureGetRequestDTO  RequestProductPictureDTO) :  IRequest<Either<GeneralFailure, ProductPictureResponseDTO>>;
    public  record GetProductPictureByGuidQuery(ProductPictureGetRequestByGuidDTO  RequestProductPictureDTO) :  IRequest<Either<GeneralFailure, ProductPictureResponseDTO>>;
    public  record GetProductPictureByIdQuery(ProductPictureGetRequestByIdDTO  RequestProductPictureDTO) :  IRequest<Either<GeneralFailure, ProductPictureResponseDTO>>;
    public  record GetAllProductPictureQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductPictureResponseDTO>>>;
}