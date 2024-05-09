using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateLogSummaryCommand(LogSummaryCreateRequestDTO  CreateLogSummaryDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}