using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  record CreateProductCertificateCommand(ProductCertificateCreateRequestDTO  CreateProductCertificateDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}