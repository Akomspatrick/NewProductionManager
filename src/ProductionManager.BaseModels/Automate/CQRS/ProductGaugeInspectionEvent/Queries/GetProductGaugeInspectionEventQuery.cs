using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductGaugeInspectionEventQuery(ProductGaugeInspectionEventGetRequestDTO  RequestProductGaugeInspectionEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>;
    public  record GetProductGaugeInspectionEventByGuidQuery(ProductGaugeInspectionEventGetRequestByGuidDTO  RequestProductGaugeInspectionEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>;
    public  record GetProductGaugeInspectionEventByIdQuery(ProductGaugeInspectionEventGetRequestByIdDTO  RequestProductGaugeInspectionEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeInspectionEventResponseDTO>>;
    public  record GetAllProductGaugeInspectionEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductGaugeInspectionEventResponseDTO>>>;
}