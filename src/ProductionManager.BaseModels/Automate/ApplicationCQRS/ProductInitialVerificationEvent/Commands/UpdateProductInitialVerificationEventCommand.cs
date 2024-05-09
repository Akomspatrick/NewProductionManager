using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductInitialVerificationEventCommand(ProductInitialVerificationEventUpdateRequestDTO  UpdateProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}