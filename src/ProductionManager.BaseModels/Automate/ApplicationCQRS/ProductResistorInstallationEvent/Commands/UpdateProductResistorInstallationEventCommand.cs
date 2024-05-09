using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductResistorInstallationEventCommand(ProductResistorInstallationEventUpdateRequestDTO  UpdateProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}