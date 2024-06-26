using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductFinishedEventCommand(ProductFinishedEventUpdateRequestDTO  UpdateProductFinishedEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}