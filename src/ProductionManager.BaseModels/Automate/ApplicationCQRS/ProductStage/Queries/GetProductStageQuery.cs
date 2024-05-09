using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductStageQuery(ProductStageGetRequestDTO  RequestProductStageDTO) :  IRequest<Either<GeneralFailure, ProductStageResponseDTO>>;
    public  record GetProductStageByGuidQuery(ProductStageGetRequestByGuidDTO  RequestProductStageDTO) :  IRequest<Either<GeneralFailure, ProductStageResponseDTO>>;
    public  record GetProductStageByIdQuery(ProductStageGetRequestByIdDTO  RequestProductStageDTO) :  IRequest<Either<GeneralFailure, ProductStageResponseDTO>>;
    public  record GetAllProductStageQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductStageResponseDTO>>>;
}