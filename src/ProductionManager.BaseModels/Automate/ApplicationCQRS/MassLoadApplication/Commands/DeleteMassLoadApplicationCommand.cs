using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteMassLoadApplicationCommand(MassLoadApplicationDeleteRequestDTO  DeleteMassLoadApplicationDTO) :  IRequest<Either<GeneralFailure, int>>;
}