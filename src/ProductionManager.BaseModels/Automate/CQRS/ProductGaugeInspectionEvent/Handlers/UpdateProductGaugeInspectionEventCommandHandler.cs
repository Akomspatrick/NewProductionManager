using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductGaugeInspectionEventCommandHandler  :  IRequestHandler<UpdateProductGaugeInspectionEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductGaugeInspectionEventCommandHandler> _logger;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductGaugeInspectionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductGaugeInspectionEventCommandHandler> logger, IMapper mapper, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductGaugeInspectionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductGaugeInspectionEvent>(request.UpdateProductGaugeInspectionEventDTO);
            return await _productGaugeInspectionEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}