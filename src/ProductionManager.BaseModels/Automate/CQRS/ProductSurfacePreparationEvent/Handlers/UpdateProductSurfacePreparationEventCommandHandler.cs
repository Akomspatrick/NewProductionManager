using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductSurfacePreparationEventCommandHandler  :  IRequestHandler<UpdateProductSurfacePreparationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductSurfacePreparationEventCommandHandler> _logger;
        public IProductSurfacePreparationEventRepository _productSurfacePreparationEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductSurfacePreparationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductSurfacePreparationEventCommandHandler> logger, IMapper mapper, IProductSurfacePreparationEventRepository productSurfacePreparationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productSurfacePreparationEventRepository = productSurfacePreparationEventRepository  ?? throw new ArgumentNullException(nameof(productSurfacePreparationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductSurfacePreparationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductSurfacePreparationEvent>(request.UpdateProductSurfacePreparationEventDTO);
            return await _productSurfacePreparationEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}