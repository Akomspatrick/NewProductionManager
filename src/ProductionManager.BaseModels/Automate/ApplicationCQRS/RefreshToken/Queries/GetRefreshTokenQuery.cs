using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetRefreshTokenQuery(RefreshTokenGetRequestDTO  RequestRefreshTokenDTO) :  IRequest<Either<GeneralFailure, RefreshTokenResponseDTO>>;
    public  record GetRefreshTokenByGuidQuery(RefreshTokenGetRequestByGuidDTO  RequestRefreshTokenDTO) :  IRequest<Either<GeneralFailure, RefreshTokenResponseDTO>>;
    public  record GetRefreshTokenByIdQuery(RefreshTokenGetRequestByIdDTO  RequestRefreshTokenDTO) :  IRequest<Either<GeneralFailure, RefreshTokenResponseDTO>>;
    public  record GetAllRefreshTokenQuery :  IRequest<Either<GeneralFailure, IEnumerable<RefreshTokenResponseDTO>>>;
}