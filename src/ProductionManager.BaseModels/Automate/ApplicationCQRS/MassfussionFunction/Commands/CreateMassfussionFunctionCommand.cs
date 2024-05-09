using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateMassfussionFunctionCommand(MassfussionFunctionCreateRequestDTO  CreateMassfussionFunctionDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}