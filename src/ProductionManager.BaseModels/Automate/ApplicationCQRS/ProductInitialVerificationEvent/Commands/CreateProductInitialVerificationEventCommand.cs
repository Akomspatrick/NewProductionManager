using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductInitialVerificationEventCommand(ProductInitialVerificationEventCreateRequestDTO  CreateProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}