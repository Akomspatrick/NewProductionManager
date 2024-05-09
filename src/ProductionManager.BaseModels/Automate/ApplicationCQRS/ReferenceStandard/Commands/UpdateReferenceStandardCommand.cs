using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateReferenceStandardCommand(ReferenceStandardUpdateRequestDTO  UpdateReferenceStandardDTO) :  IRequest<Either<GeneralFailure, int>>;
}