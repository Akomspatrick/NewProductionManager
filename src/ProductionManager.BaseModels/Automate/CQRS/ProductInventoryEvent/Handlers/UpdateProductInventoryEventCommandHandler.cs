using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductInventoryEventCommandHandler  :  IRequestHandler<UpdateProductInventoryEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductInventoryEventCommandHandler> _logger;
        public IProductInventoryEventRepository _productInventoryEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductInventoryEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductInventoryEventCommandHandler> logger, IMapper mapper, IProductInventoryEventRepository productInventoryEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productInventoryEventRepository = productInventoryEventRepository  ?? throw new ArgumentNullException(nameof(productInventoryEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductInventoryEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductInventoryEvent>(request.UpdateProductInventoryEventDTO);
            return await _productInventoryEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}