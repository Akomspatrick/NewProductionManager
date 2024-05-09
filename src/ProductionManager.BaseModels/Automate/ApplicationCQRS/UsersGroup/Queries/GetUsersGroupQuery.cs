using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetUsersGroupQuery(UsersGroupGetRequestDTO  RequestUsersGroupDTO) :  IRequest<Either<GeneralFailure, UsersGroupResponseDTO>>;
    public  record GetUsersGroupByGuidQuery(UsersGroupGetRequestByGuidDTO  RequestUsersGroupDTO) :  IRequest<Either<GeneralFailure, UsersGroupResponseDTO>>;
    public  record GetUsersGroupByIdQuery(UsersGroupGetRequestByIdDTO  RequestUsersGroupDTO) :  IRequest<Either<GeneralFailure, UsersGroupResponseDTO>>;
    public  record GetAllUsersGroupQuery :  IRequest<Either<GeneralFailure, IEnumerable<UsersGroupResponseDTO>>>;
}