using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductResistorInstallationEventCommand(ProductResistorInstallationEventCreateRequestDTO  CreateProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}