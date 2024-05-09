using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteReferenceStandardCommand(ReferenceStandardDeleteRequestDTO  DeleteReferenceStandardDTO) :  IRequest<Either<GeneralFailure, int>>;
}