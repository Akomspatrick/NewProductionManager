using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateRefreshTokenCommand(RefreshTokenCreateRequestDTO  CreateRefreshTokenDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}