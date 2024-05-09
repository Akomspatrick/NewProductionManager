using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteModelVersionCommand(ModelVersionDeleteRequestDTO  DeleteModelVersionDTO) :  IRequest<Either<GeneralFailure, int>>;
}