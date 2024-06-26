using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductSealingEventQuery(ProductSealingEventGetRequestDTO  RequestProductSealingEventDTO) :  IRequest<Either<GeneralFailure, ProductSealingEventResponseDTO>>;
    public  record GetProductSealingEventByGuidQuery(ProductSealingEventGetRequestByGuidDTO  RequestProductSealingEventDTO) :  IRequest<Either<GeneralFailure, ProductSealingEventResponseDTO>>;
    public  record GetProductSealingEventByIdQuery(ProductSealingEventGetRequestByIdDTO  RequestProductSealingEventDTO) :  IRequest<Either<GeneralFailure, ProductSealingEventResponseDTO>>;
    public  record GetAllProductSealingEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductSealingEventResponseDTO>>>;
}