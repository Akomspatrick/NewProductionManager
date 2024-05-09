using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetMassLoadApplicationQuery(MassLoadApplicationGetRequestDTO  RequestMassLoadApplicationDTO) :  IRequest<Either<GeneralFailure, MassLoadApplicationResponseDTO>>;
    public  record GetMassLoadApplicationByGuidQuery(MassLoadApplicationGetRequestByGuidDTO  RequestMassLoadApplicationDTO) :  IRequest<Either<GeneralFailure, MassLoadApplicationResponseDTO>>;
    public  record GetMassLoadApplicationByIdQuery(MassLoadApplicationGetRequestByIdDTO  RequestMassLoadApplicationDTO) :  IRequest<Either<GeneralFailure, MassLoadApplicationResponseDTO>>;
    public  record GetAllMassLoadApplicationQuery :  IRequest<Either<GeneralFailure, IEnumerable<MassLoadApplicationResponseDTO>>>;
}