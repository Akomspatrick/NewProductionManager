using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateDefectTypeCommand(DefectTypeUpdateRequestDTO  UpdateDefectTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}