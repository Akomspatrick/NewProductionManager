using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductFinalUnitCommand(ProductFinalUnitUpdateRequestDTO  UpdateProductFinalUnitDTO) :  IRequest<Either<GeneralFailure, int>>;
}