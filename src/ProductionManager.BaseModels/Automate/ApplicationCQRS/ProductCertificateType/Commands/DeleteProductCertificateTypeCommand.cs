using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record DeleteProductCertificateTypeCommand(ProductCertificateTypeDeleteRequestDTO  DeleteProductCertificateTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}