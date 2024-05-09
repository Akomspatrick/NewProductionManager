using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductCertificateTypeCommand(ProductCertificateTypeUpdateRequestDTO  UpdateProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}