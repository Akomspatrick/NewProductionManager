using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateShuntResistorCommand(ShuntResistorUpdateRequestDTO  UpdateShuntResistorDTO) :  IRequest<Either<GeneralFailure, int>>;
}