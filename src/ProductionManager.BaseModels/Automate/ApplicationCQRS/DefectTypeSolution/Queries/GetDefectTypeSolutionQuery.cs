using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetDefectTypeSolutionQuery(DefectTypeSolutionGetRequestDTO  RequestDefectTypeSolutionDTO) :  IRequest<Either<GeneralFailure, DefectTypeSolutionResponseDTO>>;
    public  record GetDefectTypeSolutionByGuidQuery(DefectTypeSolutionGetRequestByGuidDTO  RequestDefectTypeSolutionDTO) :  IRequest<Either<GeneralFailure, DefectTypeSolutionResponseDTO>>;
    public  record GetDefectTypeSolutionByIdQuery(DefectTypeSolutionGetRequestByIdDTO  RequestDefectTypeSolutionDTO) :  IRequest<Either<GeneralFailure, DefectTypeSolutionResponseDTO>>;
    public  record GetAllDefectTypeSolutionQuery :  IRequest<Either<GeneralFailure, IEnumerable<DefectTypeSolutionResponseDTO>>>;
}