using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateMassLoadApplicationCommand(MassLoadApplicationUpdateRequestDTO  UpdateMassLoadApplicationDTO) :  IRequest<Either<GeneralFailure, int>>;
}