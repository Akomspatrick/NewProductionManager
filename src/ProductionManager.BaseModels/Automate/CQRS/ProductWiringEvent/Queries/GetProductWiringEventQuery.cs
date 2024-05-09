using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductWiringEventQuery(ProductWiringEventGetRequestDTO  RequestProductWiringEventDTO) :  IRequest<Either<GeneralFailure, ProductWiringEventResponseDTO>>;
    public  record GetProductWiringEventByGuidQuery(ProductWiringEventGetRequestByGuidDTO  RequestProductWiringEventDTO) :  IRequest<Either<GeneralFailure, ProductWiringEventResponseDTO>>;
    public  record GetProductWiringEventByIdQuery(ProductWiringEventGetRequestByIdDTO  RequestProductWiringEventDTO) :  IRequest<Either<GeneralFailure, ProductWiringEventResponseDTO>>;
    public  record GetAllProductWiringEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductWiringEventResponseDTO>>>;
}