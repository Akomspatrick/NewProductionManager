using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetTrimmingResistorQuery(TrimmingResistorGetRequestDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetTrimmingResistorByGuidQuery(TrimmingResistorGetRequestByGuidDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetTrimmingResistorByIdQuery(TrimmingResistorGetRequestByIdDTO  RequestTrimmingResistorDTO) :  IRequest<Either<GeneralFailure, TrimmingResistorResponseDTO>>;
    public  record GetAllTrimmingResistorQuery :  IRequest<Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>>;
}