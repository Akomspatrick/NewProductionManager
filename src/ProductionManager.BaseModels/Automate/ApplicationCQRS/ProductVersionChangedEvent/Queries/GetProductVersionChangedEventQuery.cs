using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductVersionChangedEventQuery(ProductVersionChangedEventGetRequestDTO  RequestProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>;
    public  record GetProductVersionChangedEventByGuidQuery(ProductVersionChangedEventGetRequestByGuidDTO  RequestProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>;
    public  record GetProductVersionChangedEventByIdQuery(ProductVersionChangedEventGetRequestByIdDTO  RequestProductVersionChangedEventDTO) :  IRequest<Either<GeneralFailure, ProductVersionChangedEventResponseDTO>>;
    public  record GetAllProductVersionChangedEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductVersionChangedEventResponseDTO>>>;
}