using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateAmplifierBoardCommand(AmplifierBoardUpdateRequestDTO  UpdateAmplifierBoardDTO) :  IRequest<Either<GeneralFailure, int>>;
}