using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateNonConformanceLogCommand(NonConformanceLogCreateRequestDTO  CreateNonConformanceLogDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}