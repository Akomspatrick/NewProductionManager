using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetReferenceStandardQuery(ReferenceStandardGetRequestDTO  RequestReferenceStandardDTO) :  IRequest<Either<GeneralFailure, ReferenceStandardResponseDTO>>;
    public  record GetReferenceStandardByGuidQuery(ReferenceStandardGetRequestByGuidDTO  RequestReferenceStandardDTO) :  IRequest<Either<GeneralFailure, ReferenceStandardResponseDTO>>;
    public  record GetReferenceStandardByIdQuery(ReferenceStandardGetRequestByIdDTO  RequestReferenceStandardDTO) :  IRequest<Either<GeneralFailure, ReferenceStandardResponseDTO>>;
    public  record GetAllReferenceStandardQuery :  IRequest<Either<GeneralFailure, IEnumerable<ReferenceStandardResponseDTO>>>;
}