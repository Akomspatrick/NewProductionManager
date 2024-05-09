using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateTestCommand(TestCreateRequestDTO  CreateTestDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}