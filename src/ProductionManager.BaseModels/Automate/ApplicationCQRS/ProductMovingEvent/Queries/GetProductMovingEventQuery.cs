using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductMovingEventQuery(ProductMovingEventGetRequestDTO  RequestProductMovingEventDTO) :  IRequest<Either<GeneralFailure, ProductMovingEventResponseDTO>>;
    public  record GetProductMovingEventByGuidQuery(ProductMovingEventGetRequestByGuidDTO  RequestProductMovingEventDTO) :  IRequest<Either<GeneralFailure, ProductMovingEventResponseDTO>>;
    public  record GetProductMovingEventByIdQuery(ProductMovingEventGetRequestByIdDTO  RequestProductMovingEventDTO) :  IRequest<Either<GeneralFailure, ProductMovingEventResponseDTO>>;
    public  record GetAllProductMovingEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductMovingEventResponseDTO>>>;
}