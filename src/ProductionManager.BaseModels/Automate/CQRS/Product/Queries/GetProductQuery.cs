using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetProductQuery(ProductGetRequestDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ProductResponseDTO>>;
    public  record GetProductByGuidQuery(ProductGetRequestByGuidDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ProductResponseDTO>>;
    public  record GetProductByIdQuery(ProductGetRequestByIdDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ProductResponseDTO>>;
    public  record GetAllProductQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProductResponseDTO>>>;
}