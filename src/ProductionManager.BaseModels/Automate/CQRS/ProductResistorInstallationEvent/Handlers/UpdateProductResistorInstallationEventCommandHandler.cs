using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductResistorInstallationEventCommandHandler  :  IRequestHandler<UpdateProductResistorInstallationEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductResistorInstallationEventCommandHandler> _logger;
        public IProductResistorInstallationEventRepository _productResistorInstallationEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductResistorInstallationEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductResistorInstallationEventCommandHandler> logger, IMapper mapper, IProductResistorInstallationEventRepository productResistorInstallationEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productResistorInstallationEventRepository = productResistorInstallationEventRepository  ?? throw new ArgumentNullException(nameof(productResistorInstallationEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductResistorInstallationEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductResistorInstallationEvent>(request.UpdateProductResistorInstallationEventDTO);
            return await _productResistorInstallationEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}