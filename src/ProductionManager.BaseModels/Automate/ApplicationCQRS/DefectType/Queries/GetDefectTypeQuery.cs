using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetDefectTypeQuery(DefectTypeGetRequestDTO  RequestDefectTypeDTO) :  IRequest<Either<GeneralFailure, DefectTypeResponseDTO>>;
    public  record GetDefectTypeByGuidQuery(DefectTypeGetRequestByGuidDTO  RequestDefectTypeDTO) :  IRequest<Either<GeneralFailure, DefectTypeResponseDTO>>;
    public  record GetDefectTypeByIdQuery(DefectTypeGetRequestByIdDTO  RequestDefectTypeDTO) :  IRequest<Either<GeneralFailure, DefectTypeResponseDTO>>;
    public  record GetAllDefectTypeQuery :  IRequest<Either<GeneralFailure, IEnumerable<DefectTypeResponseDTO>>>;
}