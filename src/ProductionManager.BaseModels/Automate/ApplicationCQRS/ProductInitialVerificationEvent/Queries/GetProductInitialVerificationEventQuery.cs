using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductInitialVerificationEventQuery(ProductInitialVerificationEventGetRequestDTO  RequestProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>;
    public  record GetProductInitialVerificationEventByGuidQuery(ProductInitialVerificationEventGetRequestByGuidDTO  RequestProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>;
    public  record GetProductInitialVerificationEventByIdQuery(ProductInitialVerificationEventGetRequestByIdDTO  RequestProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, ProductInitialVerificationEventResponseDTO>>;
    public  record GetAllProductInitialVerificationEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductInitialVerificationEventResponseDTO>>>;
}