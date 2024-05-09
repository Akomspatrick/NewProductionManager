using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateRefreshTokenCommand(RefreshTokenUpdateRequestDTO  UpdateRefreshTokenDTO) :  IRequest<Either<GeneralFailure, int>>;
}