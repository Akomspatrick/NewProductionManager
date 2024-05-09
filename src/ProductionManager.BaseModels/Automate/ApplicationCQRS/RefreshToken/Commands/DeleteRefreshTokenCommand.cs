using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteRefreshTokenCommand(RefreshTokenDeleteRequestDTO  DeleteRefreshTokenDTO) :  IRequest<Either<GeneralFailure, int>>;
}