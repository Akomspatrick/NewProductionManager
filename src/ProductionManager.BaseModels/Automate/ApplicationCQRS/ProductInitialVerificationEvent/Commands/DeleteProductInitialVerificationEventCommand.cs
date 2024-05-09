using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductInitialVerificationEventCommand(ProductInitialVerificationEventDeleteRequestDTO  DeleteProductInitialVerificationEventDTO) :  IRequest<Either<GeneralFailure, int>>;
}