using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetShuntResistorQuery(ShuntResistorGetRequestDTO  RequestShuntResistorDTO) :  IRequest<Either<GeneralFailure, ShuntResistorResponseDTO>>;
    public  record GetShuntResistorByGuidQuery(ShuntResistorGetRequestByGuidDTO  RequestShuntResistorDTO) :  IRequest<Either<GeneralFailure, ShuntResistorResponseDTO>>;
    public  record GetShuntResistorByIdQuery(ShuntResistorGetRequestByIdDTO  RequestShuntResistorDTO) :  IRequest<Either<GeneralFailure, ShuntResistorResponseDTO>>;
    public  record GetAllShuntResistorQuery :  IRequest<Either<GeneralFailure, IEnumerable<ShuntResistorResponseDTO>>>;
}