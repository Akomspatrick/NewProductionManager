using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductCertificateQuery(ProductCertificateGetRequestDTO  RequestProductCertificateDTO) :  IRequest<Either<GeneralFailure, ProductCertificateResponseDTO>>;
    public  record GetProductCertificateByGuidQuery(ProductCertificateGetRequestByGuidDTO  RequestProductCertificateDTO) :  IRequest<Either<GeneralFailure, ProductCertificateResponseDTO>>;
    public  record GetProductCertificateByIdQuery(ProductCertificateGetRequestByIdDTO  RequestProductCertificateDTO) :  IRequest<Either<GeneralFailure, ProductCertificateResponseDTO>>;
    public  record GetAllProductCertificateQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductCertificateResponseDTO>>>;
}