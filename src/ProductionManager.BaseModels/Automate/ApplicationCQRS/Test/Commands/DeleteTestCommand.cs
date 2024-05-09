using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteTestCommand(TestDeleteRequestDTO  DeleteTestDTO) :  IRequest<Either<GeneralFailure, int>>;
}