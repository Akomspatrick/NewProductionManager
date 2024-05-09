using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductInventoryEventQuery(ProductInventoryEventGetRequestDTO  RequestProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, ProductInventoryEventResponseDTO>>;
    public  record GetProductInventoryEventByGuidQuery(ProductInventoryEventGetRequestByGuidDTO  RequestProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, ProductInventoryEventResponseDTO>>;
    public  record GetProductInventoryEventByIdQuery(ProductInventoryEventGetRequestByIdDTO  RequestProductInventoryEventDTO) :  IRequest<Either<GeneralFailure, ProductInventoryEventResponseDTO>>;
    public  record GetAllProductInventoryEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductInventoryEventResponseDTO>>>;
}