using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductLabellingEventCommandHandler  :  IRequestHandler<UpdateProductLabellingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductLabellingEventCommandHandler> _logger;
        public IProductLabellingEventRepository _productLabellingEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductLabellingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductLabellingEventCommandHandler> logger, IMapper mapper, IProductLabellingEventRepository productLabellingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productLabellingEventRepository = productLabellingEventRepository  ?? throw new ArgumentNullException(nameof(productLabellingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductLabellingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductLabellingEvent>(request.UpdateProductLabellingEventDTO);
            return await _productLabellingEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}