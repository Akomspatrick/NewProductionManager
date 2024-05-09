using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateModelVersionCommand(ModelVersionCreateRequestDTO  CreateModelVersionDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}