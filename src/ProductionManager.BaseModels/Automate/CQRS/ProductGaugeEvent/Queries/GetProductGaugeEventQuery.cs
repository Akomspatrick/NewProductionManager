using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductGaugeEventQuery(ProductGaugeEventGetRequestDTO  RequestProductGaugeEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeEventResponseDTO>>;
    public  record GetProductGaugeEventByGuidQuery(ProductGaugeEventGetRequestByGuidDTO  RequestProductGaugeEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeEventResponseDTO>>;
    public  record GetProductGaugeEventByIdQuery(ProductGaugeEventGetRequestByIdDTO  RequestProductGaugeEventDTO) :  IRequest<Either<GeneralFailure, ProductGaugeEventResponseDTO>>;
    public  record GetAllProductGaugeEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductGaugeEventResponseDTO>>>;
}