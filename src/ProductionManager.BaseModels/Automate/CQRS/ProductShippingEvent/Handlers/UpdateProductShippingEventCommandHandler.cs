using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductShippingEventCommandHandler  :  IRequestHandler<UpdateProductShippingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductShippingEventCommandHandler> _logger;
        public IProductShippingEventRepository _productShippingEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductShippingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductShippingEventCommandHandler> logger, IMapper mapper, IProductShippingEventRepository productShippingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productShippingEventRepository = productShippingEventRepository  ?? throw new ArgumentNullException(nameof(productShippingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductShippingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductShippingEvent>(request.UpdateProductShippingEventDTO);
            return await _productShippingEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}