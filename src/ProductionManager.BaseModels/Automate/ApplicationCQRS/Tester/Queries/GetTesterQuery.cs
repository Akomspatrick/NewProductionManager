using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetTesterQuery(TesterGetRequestDTO  RequestTesterDTO) :  IRequest<Either<GeneralFailure, TesterResponseDTO>>;
    public  record GetTesterByGuidQuery(TesterGetRequestByGuidDTO  RequestTesterDTO) :  IRequest<Either<GeneralFailure, TesterResponseDTO>>;
    public  record GetTesterByIdQuery(TesterGetRequestByIdDTO  RequestTesterDTO) :  IRequest<Either<GeneralFailure, TesterResponseDTO>>;
    public  record GetAllTesterQuery :  IRequest<Either<GeneralFailure, IEnumerable<TesterResponseDTO>>>;
}