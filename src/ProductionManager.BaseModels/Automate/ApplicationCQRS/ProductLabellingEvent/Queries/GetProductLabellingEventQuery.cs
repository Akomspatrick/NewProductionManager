using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductLabellingEventQuery(ProductLabellingEventGetRequestDTO  RequestProductLabellingEventDTO) :  IRequest<Either<GeneralFailure, ProductLabellingEventResponseDTO>>;
    public  record GetProductLabellingEventByGuidQuery(ProductLabellingEventGetRequestByGuidDTO  RequestProductLabellingEventDTO) :  IRequest<Either<GeneralFailure, ProductLabellingEventResponseDTO>>;
    public  record GetProductLabellingEventByIdQuery(ProductLabellingEventGetRequestByIdDTO  RequestProductLabellingEventDTO) :  IRequest<Either<GeneralFailure, ProductLabellingEventResponseDTO>>;
    public  record GetAllProductLabellingEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductLabellingEventResponseDTO>>>;
}