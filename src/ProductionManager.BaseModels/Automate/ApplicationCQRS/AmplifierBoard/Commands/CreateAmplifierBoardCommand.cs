using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateAmplifierBoardCommand(AmplifierBoardCreateRequestDTO  CreateAmplifierBoardDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}