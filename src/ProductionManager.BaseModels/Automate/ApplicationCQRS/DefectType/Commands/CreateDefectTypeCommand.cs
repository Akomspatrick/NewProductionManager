using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateDefectTypeCommand(DefectTypeCreateRequestDTO  CreateDefectTypeDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}