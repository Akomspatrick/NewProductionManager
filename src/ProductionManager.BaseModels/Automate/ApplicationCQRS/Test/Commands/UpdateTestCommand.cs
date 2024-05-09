using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateTestCommand(TestUpdateRequestDTO  UpdateTestDTO) :  IRequest<Either<GeneralFailure, int>>;
}