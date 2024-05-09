using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetAmplifierBoardQuery(AmplifierBoardGetRequestDTO  RequestAmplifierBoardDTO) :  IRequest<Either<GeneralFailure, AmplifierBoardResponseDTO>>;
    public  record GetAmplifierBoardByGuidQuery(AmplifierBoardGetRequestByGuidDTO  RequestAmplifierBoardDTO) :  IRequest<Either<GeneralFailure, AmplifierBoardResponseDTO>>;
    public  record GetAmplifierBoardByIdQuery(AmplifierBoardGetRequestByIdDTO  RequestAmplifierBoardDTO) :  IRequest<Either<GeneralFailure, AmplifierBoardResponseDTO>>;
    public  record GetAllAmplifierBoardQuery :  IRequest<Either<GeneralFailure, IEnumerable<AmplifierBoardResponseDTO>>>;
}