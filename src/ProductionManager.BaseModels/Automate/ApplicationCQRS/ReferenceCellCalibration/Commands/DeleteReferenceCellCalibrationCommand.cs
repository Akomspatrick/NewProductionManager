using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteReferenceCellCalibrationCommand(ReferenceCellCalibrationDeleteRequestDTO  DeleteReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, int>>;
}