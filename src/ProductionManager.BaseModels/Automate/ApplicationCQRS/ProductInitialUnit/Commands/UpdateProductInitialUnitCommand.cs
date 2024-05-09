using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductInitialUnitCommand(ProductInitialUnitUpdateRequestDTO  UpdateProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, int>>;
}