using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductFinishedEventCommand(ProductFinishedEventDeleteRequestDTO  DeleteProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}