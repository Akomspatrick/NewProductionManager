using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductFinalUnitQuery(ProductFinalUnitGetRequestDTO  RequestProductFinalUnitDTO) :  IRequest<Either<GeneralFailure, ProductFinalUnitResponseDTO>>;
    public  record GetProductFinalUnitByGuidQuery(ProductFinalUnitGetRequestByGuidDTO  RequestProductFinalUnitDTO) :  IRequest<Either<GeneralFailure, ProductFinalUnitResponseDTO>>;
    public  record GetProductFinalUnitByIdQuery(ProductFinalUnitGetRequestByIdDTO  RequestProductFinalUnitDTO) :  IRequest<Either<GeneralFailure, ProductFinalUnitResponseDTO>>;
    public  record GetAllProductFinalUnitQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductFinalUnitResponseDTO>>>;
}