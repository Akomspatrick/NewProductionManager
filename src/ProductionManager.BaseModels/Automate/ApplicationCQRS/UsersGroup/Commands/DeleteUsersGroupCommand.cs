using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteUsersGroupCommand(UsersGroupDeleteRequestDTO  DeleteUsersGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}