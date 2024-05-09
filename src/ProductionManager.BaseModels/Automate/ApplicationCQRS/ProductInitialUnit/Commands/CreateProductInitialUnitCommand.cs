using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductInitialUnitCommand(ProductInitialUnitCreateRequestDTO  CreateProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}