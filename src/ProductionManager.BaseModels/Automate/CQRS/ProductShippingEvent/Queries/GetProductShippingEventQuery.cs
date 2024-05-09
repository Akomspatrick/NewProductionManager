using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductShippingEventQuery(ProductShippingEventGetRequestDTO  RequestProductShippingEventDTO) :  IRequest<Either<GeneralFailure, ProductShippingEventResponseDTO>>;
    public  record GetProductShippingEventByGuidQuery(ProductShippingEventGetRequestByGuidDTO  RequestProductShippingEventDTO) :  IRequest<Either<GeneralFailure, ProductShippingEventResponseDTO>>;
    public  record GetProductShippingEventByIdQuery(ProductShippingEventGetRequestByIdDTO  RequestProductShippingEventDTO) :  IRequest<Either<GeneralFailure, ProductShippingEventResponseDTO>>;
    public  record GetAllProductShippingEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductShippingEventResponseDTO>>>;
}