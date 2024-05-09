using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteMassfussionFunctionCommand(MassfussionFunctionDeleteRequestDTO  DeleteMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, int>>;
}