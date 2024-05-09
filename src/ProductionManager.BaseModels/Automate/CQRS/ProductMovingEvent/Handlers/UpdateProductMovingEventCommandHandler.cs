using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductMovingEventCommandHandler  :  IRequestHandler<UpdateProductMovingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductMovingEventCommandHandler> _logger;
        public IProductMovingEventRepository _productMovingEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductMovingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductMovingEventCommandHandler> logger, IMapper mapper, IProductMovingEventRepository productMovingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productMovingEventRepository = productMovingEventRepository  ?? throw new ArgumentNullException(nameof(productMovingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductMovingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductMovingEvent>(request.UpdateProductMovingEventDTO);
            return await _productMovingEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}