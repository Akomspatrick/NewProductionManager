using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductReceptionEventQuery(ProductReceptionEventGetRequestDTO  RequestProductReceptionEventDTO) :  IRequest<Either<GeneralFailure, ProductReceptionEventResponseDTO>>;
    public  record GetProductReceptionEventByGuidQuery(ProductReceptionEventGetRequestByGuidDTO  RequestProductReceptionEventDTO) :  IRequest<Either<GeneralFailure, ProductReceptionEventResponseDTO>>;
    public  record GetProductReceptionEventByIdQuery(ProductReceptionEventGetRequestByIdDTO  RequestProductReceptionEventDTO) :  IRequest<Either<GeneralFailure, ProductReceptionEventResponseDTO>>;
    public  record GetAllProductReceptionEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductReceptionEventResponseDTO>>>;
}