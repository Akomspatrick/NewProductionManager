using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductGaugeInspectionEventCommand(ProductGaugeInspectionEventCreateRequestDTO  CreateProductGaugeInspectionEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}