using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetTrimmingResistorQuery(TrimmingResistorGetRequestDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetTrimmingResistorByGuidQuery(TrimmingResistorGetRequestByGuidDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetTrimmingResistorByIdQuery(TrimmingResistorGetRequestByIdDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetAllTrimmingResistorQuery :  IRequest<Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>>;
}