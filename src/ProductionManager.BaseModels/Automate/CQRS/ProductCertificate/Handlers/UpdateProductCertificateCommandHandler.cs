using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductCertificateCommandHandler  :  IRequestHandler<UpdateProductCertificateCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductCertificateCommandHandler> _logger;
        public IProductCertificateRepository _productCertificateRepository ;
        private readonly IMapper _mapper;
        public UpdateProductCertificateCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductCertificateCommandHandler> logger, IMapper mapper, IProductCertificateRepository productCertificateRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productCertificateRepository = productCertificateRepository  ?? throw new ArgumentNullException(nameof(productCertificateRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductCertificateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductCertificate>(request.UpdateProductCertificateDTO);
            return await _productCertificateRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}