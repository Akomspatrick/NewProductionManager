using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetReferenceCellCalibrationQuery(ReferenceCellCalibrationGetRequestDTO  RequestReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>;
    public  record GetReferenceCellCalibrationByGuidQuery(ReferenceCellCalibrationGetRequestByGuidDTO  RequestReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>;
    public  record GetReferenceCellCalibrationByIdQuery(ReferenceCellCalibrationGetRequestByIdDTO  RequestReferenceCellCalibrationDTO) :  IRequest<Either<GeneralFailure, ReferenceCellCalibrationResponseDTO>>;
    public  record GetAllReferenceCellCalibrationQuery :  IRequest<Either<GeneralFailure, IEnumerable<ReferenceCellCalibrationResponseDTO>>>;
}