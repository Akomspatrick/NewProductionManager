using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductSurfacePreparationEventQuery(ProductSurfacePreparationEventGetRequestDTO  RequestProductSurfacePreparationEventDTO) :  IRequest<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>;
    public  record GetProductSurfacePreparationEventByGuidQuery(ProductSurfacePreparationEventGetRequestByGuidDTO  RequestProductSurfacePreparationEventDTO) :  IRequest<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>;
    public  record GetProductSurfacePreparationEventByIdQuery(ProductSurfacePreparationEventGetRequestByIdDTO  RequestProductSurfacePreparationEventDTO) :  IRequest<Either<GeneralFailure, ProductSurfacePreparationEventResponseDTO>>;
    public  record GetAllProductSurfacePreparationEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductSurfacePreparationEventResponseDTO>>>;
}