using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateDefectTypeSolutionCommand(DefectTypeSolutionUpdateRequestDTO  UpdateDefectTypeSolutionDTO) :  IRequest<Either<GeneralFailure, int>>;
}