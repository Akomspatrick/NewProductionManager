using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductAdditionalInfoQuery(ProductAdditionalInfoGetRequestDTO  RequestProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>;
    public  record GetProductAdditionalInfoByGuidQuery(ProductAdditionalInfoGetRequestByGuidDTO  RequestProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>;
    public  record GetProductAdditionalInfoByIdQuery(ProductAdditionalInfoGetRequestByIdDTO  RequestProductAdditionalInfoDTO) :  IRequest<Either<GeneralFailure, ProductAdditionalInfoResponseDTO>>;
    public  record GetAllProductAdditionalInfoQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductAdditionalInfoResponseDTO>>>;
}