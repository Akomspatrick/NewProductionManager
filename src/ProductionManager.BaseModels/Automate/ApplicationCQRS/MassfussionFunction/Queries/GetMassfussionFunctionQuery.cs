using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetMassfussionFunctionQuery(MassfussionFunctionGetRequestDTO  RequestMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, MassfussionFunctionResponseDTO>>;
    public  record GetMassfussionFunctionByGuidQuery(MassfussionFunctionGetRequestByGuidDTO  RequestMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, MassfussionFunctionResponseDTO>>;
    public  record GetMassfussionFunctionByIdQuery(MassfussionFunctionGetRequestByIdDTO  RequestMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, MassfussionFunctionResponseDTO>>;
    public  record GetAllMassfussionFunctionQuery :  IRequest<Either<GeneralFailure, IEnumerable<MassfussionFunctionResponseDTO>>>;
}