using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductInitialVerificationEventCommandHandler  :  IRequestHandler<UpdateProductInitialVerificationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductInitialVerificationEventCommandHandler> _logger;
        public IProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductInitialVerificationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductInitialVerificationEventCommandHandler> logger, IMapper mapper, IProductInitialVerificationEventRepository productInitialVerificationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productInitialVerificationEventRepository = productInitialVerificationEventRepository  ?? throw new ArgumentNullException(nameof(productInitialVerificationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductInitialVerificationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductInitialVerificationEvent>(request.UpdateProductInitialVerificationEventDTO);
            return await _productInitialVerificationEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}