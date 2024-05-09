using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateProductInitialVerificationEventCommandHandler  :  IRequestHandler<CreateProductInitialVerificationEventCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProductInitialVerificationEventCommandHandler> _logger;
        public IProductInitialVerificationEventRepository _productInitialVerificationEventRepository ;
        public CreateProductInitialVerificationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProductInitialVerificationEventCommandHandler> logger, IProductInitialVerificationEventRepository productInitialVerificationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productInitialVerificationEventRepository = productInitialVerificationEventRepository  ?? throw new ArgumentNullException(nameof(productInitialVerificationEventRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProductInitialVerificationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProductInitialVerificationEvent.Create(request.productInitialVerificationEventCreateDTO.ProductInitialVerificationEventName, request.productInitialVerificationEventCreateDTO.Value.GuidId);return ( await  _productInitialVerificationEventRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}