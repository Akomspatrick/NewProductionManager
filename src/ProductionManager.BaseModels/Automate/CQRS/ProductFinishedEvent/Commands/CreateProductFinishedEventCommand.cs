using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductFinishedEventCommand(ProductFinishedEventCreateRequestDTO  CreateProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}