using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateModelVersionCommand(ModelVersionUpdateRequestDTO  UpdateModelVersionDTO) :  IRequest<Either<GeneralFailure, int>>;
}