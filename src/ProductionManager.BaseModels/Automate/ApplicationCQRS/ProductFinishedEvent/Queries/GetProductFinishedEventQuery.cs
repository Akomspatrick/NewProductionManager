using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductFinishedEventQuery(ProductFinishedEventGetRequestDTO  RequestProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, ProductFinishedEventResponseDTO>>;
    public  record GetProductFinishedEventByGuidQuery(ProductFinishedEventGetRequestByGuidDTO  RequestProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, ProductFinishedEventResponseDTO>>;
    public  record GetProductFinishedEventByIdQuery(ProductFinishedEventGetRequestByIdDTO  RequestProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, ProductFinishedEventResponseDTO>>;
    public  record GetAllProductFinishedEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductFinishedEventResponseDTO>>>;
}