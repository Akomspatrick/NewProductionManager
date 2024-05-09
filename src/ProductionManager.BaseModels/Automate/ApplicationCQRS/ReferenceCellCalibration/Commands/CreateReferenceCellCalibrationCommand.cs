using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateReferenceCellCalibrationCommand(ReferenceCellCalibrationCreateRequestDTO  CreateReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}