using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateNonConformanceLogCommand(NonConformanceLogUpdateRequestDTO  UpdateNonConformanceLogDTO) :  IRequest<Either<GeneralFailure, int>>;
}