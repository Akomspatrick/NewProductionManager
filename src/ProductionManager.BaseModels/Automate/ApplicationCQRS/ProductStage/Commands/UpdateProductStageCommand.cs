using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductStageCommand(ProductStageUpdateRequestDTO  UpdateProductStageDTO) :  IRequest<Either<GeneralFailure, int>>;
}