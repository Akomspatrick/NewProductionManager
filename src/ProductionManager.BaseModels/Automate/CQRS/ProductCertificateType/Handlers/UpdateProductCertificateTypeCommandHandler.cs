using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductCertificateTypeCommandHandler  :  IRequestHandler<UpdateProductCertificateTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductCertificateTypeCommandHandler> _logger;
        public IProductCertificateTypeRepository _productCertificateTypeRepository ;
        private readonly IMapper _mapper;
        public UpdateProductCertificateTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductCertificateTypeCommandHandler> logger, IMapper mapper, IProductCertificateTypeRepository productCertificateTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productCertificateTypeRepository = productCertificateTypeRepository  ?? throw new ArgumentNullException(nameof(productCertificateTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductCertificateTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductCertificateType>(request.UpdateProductCertificateTypeDTO);
            return await _productCertificateTypeRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}