using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductSealingEventCommandHandler  :  IRequestHandler<UpdateProductSealingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductSealingEventCommandHandler> _logger;
        public IProductSealingEventRepository _productSealingEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductSealingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductSealingEventCommandHandler> logger, IMapper mapper, IProductSealingEventRepository productSealingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productSealingEventRepository = productSealingEventRepository  ?? throw new ArgumentNullException(nameof(productSealingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductSealingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductSealingEvent>(request.UpdateProductSealingEventDTO);
            return await _productSealingEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}