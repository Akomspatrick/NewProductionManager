using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductReceptionEventCommandHandler  :  IRequestHandler<UpdateProductReceptionEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductReceptionEventCommandHandler> _logger;
        public IProductReceptionEventRepository _productReceptionEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductReceptionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductReceptionEventCommandHandler> logger, IMapper mapper, IProductReceptionEventRepository productReceptionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productReceptionEventRepository = productReceptionEventRepository  ?? throw new ArgumentNullException(nameof(productReceptionEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductReceptionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductReceptionEvent>(request.UpdateProductReceptionEventDTO);
            return await _productReceptionEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}