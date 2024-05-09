using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetModelVersionQuery(ModelVersionGetRequestDTO  RequestModelVersionDTO) :  IRequest<Either<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetModelVersionByGuidQuery(ModelVersionGetRequestByGuidDTO  RequestModelVersionDTO) :  IRequest<Either<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetModelVersionByIdQuery(ModelVersionGetRequestByIdDTO  RequestModelVersionDTO) :  IRequest<Either<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetAllModelVersionQuery :  IRequest<Either<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>>;
}