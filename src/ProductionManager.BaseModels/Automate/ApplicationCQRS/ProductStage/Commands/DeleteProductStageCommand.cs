using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductStageCommand(ProductStageDeleteRequestDTO  DeleteProductStageDTO) :  IRequest<Either<GeneralFailure, int>>;
}