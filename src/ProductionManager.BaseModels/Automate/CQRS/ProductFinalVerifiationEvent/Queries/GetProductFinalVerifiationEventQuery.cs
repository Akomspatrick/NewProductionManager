using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductFinalVerifiationEventQuery(ProductFinalVerifiationEventGetRequestDTO  RequestProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>;
    public  record GetProductFinalVerifiationEventByGuidQuery(ProductFinalVerifiationEventGetRequestByGuidDTO  RequestProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>;
    public  record GetProductFinalVerifiationEventByIdQuery(ProductFinalVerifiationEventGetRequestByIdDTO  RequestProductFinalVerifiationEventDTO) :  IRequest<Either<GeneralFailure, ProductFinalVerifiationEventResponseDTO>>;
    public  record GetAllProductFinalVerifiationEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductFinalVerifiationEventResponseDTO>>>;
}