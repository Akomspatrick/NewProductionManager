using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateReferenceCellCalibrationCommand(ReferenceCellCalibrationUpdateRequestDTO  UpdateReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, int>>;
}