using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductInitialUnitQuery(ProductInitialUnitGetRequestDTO  RequestProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, ProductInitialUnitResponseDTO>>;
    public  record GetProductInitialUnitByGuidQuery(ProductInitialUnitGetRequestByGuidDTO  RequestProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, ProductInitialUnitResponseDTO>>;
    public  record GetProductInitialUnitByIdQuery(ProductInitialUnitGetRequestByIdDTO  RequestProductInitialUnitDTO) :  IRequest<Either<GeneralFailure, ProductInitialUnitResponseDTO>>;
    public  record GetAllProductInitialUnitQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductInitialUnitResponseDTO>>>;
}