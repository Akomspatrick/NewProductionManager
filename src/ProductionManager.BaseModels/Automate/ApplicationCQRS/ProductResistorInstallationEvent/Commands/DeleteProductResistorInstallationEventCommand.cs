using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductResistorInstallationEventCommand(ProductResistorInstallationEventDeleteRequestDTO  DeleteProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}