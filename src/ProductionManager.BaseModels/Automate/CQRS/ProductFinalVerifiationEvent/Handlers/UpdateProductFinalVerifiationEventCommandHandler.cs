using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductFinalVerifiationEventCommandHandler  :  IRequestHandler<UpdateProductFinalVerifiationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductFinalVerifiationEventCommandHandler> _logger;
        public IProductFinalVerifiationEventRepository _productFinalVerifiationEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductFinalVerifiationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductFinalVerifiationEventCommandHandler> logger, IMapper mapper, IProductFinalVerifiationEventRepository productFinalVerifiationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productFinalVerifiationEventRepository = productFinalVerifiationEventRepository  ?? throw new ArgumentNullException(nameof(productFinalVerifiationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductFinalVerifiationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductFinalVerifiationEvent>(request.UpdateProductFinalVerifiationEventDTO);
            return await _productFinalVerifiationEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}