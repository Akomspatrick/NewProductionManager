using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductWiringEventCommandHandler  :  IRequestHandler<UpdateProductWiringEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductWiringEventCommandHandler> _logger;
        public IProductWiringEventRepository _productWiringEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductWiringEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductWiringEventCommandHandler> logger, IMapper mapper, IProductWiringEventRepository productWiringEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productWiringEventRepository = productWiringEventRepository  ?? throw new ArgumentNullException(nameof(productWiringEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductWiringEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductWiringEvent>(request.UpdateProductWiringEventDTO);
            return await _productWiringEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}