using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteLogDetailCommand(LogDetailDeleteRequestDTO  DeleteLogDetailDTO) :  IRequest<Either<GeneralFailure, int>>;
}