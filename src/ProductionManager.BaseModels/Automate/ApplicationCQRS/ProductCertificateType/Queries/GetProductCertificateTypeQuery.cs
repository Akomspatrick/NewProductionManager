using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductCertificateTypeQuery(ProductCertificateTypeGetRequestDTO  RequestProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, ProductCertificateTypeResponseDTO>>;
    public  record GetProductCertificateTypeByGuidQuery(ProductCertificateTypeGetRequestByGuidDTO  RequestProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, ProductCertificateTypeResponseDTO>>;
    public  record GetProductCertificateTypeByIdQuery(ProductCertificateTypeGetRequestByIdDTO  RequestProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, ProductCertificateTypeResponseDTO>>;
    public  record GetAllProductCertificateTypeQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductCertificateTypeResponseDTO>>>;
}