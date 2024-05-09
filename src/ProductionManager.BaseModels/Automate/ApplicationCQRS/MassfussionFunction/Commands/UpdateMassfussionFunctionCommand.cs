using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateMassfussionFunctionCommand(MassfussionFunctionUpdateRequestDTO  UpdateMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, int>>;
}