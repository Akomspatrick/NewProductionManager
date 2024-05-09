using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductGaugeEventCommandHandler  :  IRequestHandler<UpdateProductGaugeEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductGaugeEventCommandHandler> _logger;
        public IProductGaugeEventRepository _productGaugeEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductGaugeEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductGaugeEventCommandHandler> logger, IMapper mapper, IProductGaugeEventRepository productGaugeEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productGaugeEventRepository = productGaugeEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductGaugeEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductGaugeEvent>(request.UpdateProductGaugeEventDTO);
            return await _productGaugeEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}