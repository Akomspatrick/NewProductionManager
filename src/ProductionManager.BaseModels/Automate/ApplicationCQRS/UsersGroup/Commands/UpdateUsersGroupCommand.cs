using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateUsersGroupCommand(UsersGroupUpdateRequestDTO  UpdateUsersGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}