using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetLogSummaryQuery(LogSummaryGetRequestDTO  RequestLogSummaryDTO) :  IRequest<Either<GeneralFailure, LogSummaryResponseDTO>>;
    public  record GetLogSummaryByGuidQuery(LogSummaryGetRequestByGuidDTO  RequestLogSummaryDTO) :  IRequest<Either<GeneralFailure, LogSummaryResponseDTO>>;
    public  record GetLogSummaryByIdQuery(LogSummaryGetRequestByIdDTO  RequestLogSummaryDTO) :  IRequest<Either<GeneralFailure, LogSummaryResponseDTO>>;
    public  record GetAllLogSummaryQuery :  IRequest<Either<GeneralFailure, IEnumerable<LogSummaryResponseDTO>>>;
}