using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetLogDetailQuery(LogDetailGetRequestDTO  RequestLogDetailDTO) :  IRequest<Either<GeneralFailure, LogDetailResponseDTO>>;
    public  record GetLogDetailByGuidQuery(LogDetailGetRequestByGuidDTO  RequestLogDetailDTO) :  IRequest<Either<GeneralFailure, LogDetailResponseDTO>>;
    public  record GetLogDetailByIdQuery(LogDetailGetRequestByIdDTO  RequestLogDetailDTO) :  IRequest<Either<GeneralFailure, LogDetailResponseDTO>>;
    public  record GetAllLogDetailQuery :  IRequest<Either<GeneralFailure, IEnumerable<LogDetailResponseDTO>>>;
}