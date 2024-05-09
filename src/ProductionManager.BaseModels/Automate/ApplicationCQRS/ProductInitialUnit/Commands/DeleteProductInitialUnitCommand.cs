using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductInitialUnitCommand(ProductInitialUnitDeleteRequestDTO  DeleteProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, int>>;
}