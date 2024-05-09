using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetProductCertificateTypeByIdQueryHandler  :  IRequestHandler<GetProductCertificateTypeByIdQuery, Either<GeneralFailure, ProductCertificateTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetProductCertificateTypeByIdQueryHandler> _logger;
        public GetProductCertificateTypeByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetProductCertificateTypeByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ProductCertificateTypeResponseDTO>> Handle(GetProductCertificateTypeByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}