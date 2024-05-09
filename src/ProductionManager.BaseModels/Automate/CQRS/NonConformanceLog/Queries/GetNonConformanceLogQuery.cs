using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetNonConformanceLogQuery(NonConformanceLogGetRequestDTO  RequestNonConformanceLogDTO) :  IRequest<Either<GeneralFailure, NonConformanceLogResponseDTO>>;
    public  record GetNonConformanceLogByGuidQuery(NonConformanceLogGetRequestByGuidDTO  RequestNonConformanceLogDTO) :  IRequest<Either<GeneralFailure, NonConformanceLogResponseDTO>>;
    public  record GetNonConformanceLogByIdQuery(NonConformanceLogGetRequestByIdDTO  RequestNonConformanceLogDTO) :  IRequest<Either<GeneralFailure, NonConformanceLogResponseDTO>>;
    public  record GetAllNonConformanceLogQuery :  IRequest<Either<GeneralFailure, IEnumerable<NonConformanceLogResponseDTO>>>;
}