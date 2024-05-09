using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateReferenceStandardCommand(ReferenceStandardCreateRequestDTO  CreateReferenceStandardDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}