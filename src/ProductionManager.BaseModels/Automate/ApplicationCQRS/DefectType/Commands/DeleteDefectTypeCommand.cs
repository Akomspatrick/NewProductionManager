using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteDefectTypeCommand(DefectTypeDeleteRequestDTO  DeleteDefectTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}