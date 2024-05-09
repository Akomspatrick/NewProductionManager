using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductCertificateTypeCommand(ProductCertificateTypeCreateRequestDTO  CreateProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}