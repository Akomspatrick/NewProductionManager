using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductInitialUnitCommandHandler  :  IRequestHandler<UpdateProductInitialUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductInitialUnitCommandHandler> _logger;
        public IProductInitialUnitRepository _productInitialUnitRepository ;
        private readonly IMapper _mapper;
        public UpdateProductInitialUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductInitialUnitCommandHandler> logger, IMapper mapper, IProductInitialUnitRepository productInitialUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productInitialUnitRepository = productInitialUnitRepository  ?? throw new ArgumentNullException(nameof(productInitialUnitRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductInitialUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductInitialUnit>(request.UpdateProductInitialUnitDTO);
            return await _productInitialUnitRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}