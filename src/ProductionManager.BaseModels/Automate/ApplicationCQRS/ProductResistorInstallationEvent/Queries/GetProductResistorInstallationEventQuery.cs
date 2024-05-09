using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductResistorInstallationEventQuery(ProductResistorInstallationEventGetRequestDTO  RequestProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>;
    public  record GetProductResistorInstallationEventByGuidQuery(ProductResistorInstallationEventGetRequestByGuidDTO  RequestProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>;
    public  record GetProductResistorInstallationEventByIdQuery(ProductResistorInstallationEventGetRequestByIdDTO  RequestProductResistorInstallationEventDTO) :  IRequest<Either<GeneralFailure, ProductResistorInstallationEventResponseDTO>>;
    public  record GetAllProductResistorInstallationEventQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductResistorInstallationEventResponseDTO>>>;
}