using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record UpdateProductCertificateCommand(ProductCertificateUpdateRequestDTO  UpdateProductCertificateDTO) :  IRequest<Either<GeneralFailure, int>>;
}