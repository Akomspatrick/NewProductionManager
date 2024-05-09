using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductCablingEventQuery(ProductCablingEventGetRequestDTO  RequestProductCablingEventDTO) :  IRequest<Either<GeneralFailure, ProductCablingEventResponseDTO>>;
    public  record GetProductCablingEventByGuidQuery(ProductCablingEventGetRequestByGuidDTO  RequestProductCablingEventDTO) :  IRequest<Either<GeneralFailure, ProductCablingEventResponseDTO>>;
    public  record GetProductCablingEventByIdQuery(ProductCablingEventGetRequestByIdDTO  RequestProductCablingEventDTO) :  IRequest<Either<GeneralFailure, ProductCablingEventResponseDTO>>;
    public  record GetAllProductCablingEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductCablingEventResponseDTO>>>;
}