using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductFinalUnitCommandHandler  :  IRequestHandler<UpdateProductFinalUnitCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductFinalUnitCommandHandler> _logger;
        public IProductFinalUnitRepository _productFinalUnitRepository ;
        private readonly IMapper _mapper;
        public UpdateProductFinalUnitCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductFinalUnitCommandHandler> logger, IMapper mapper, IProductFinalUnitRepository productFinalUnitRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productFinalUnitRepository = productFinalUnitRepository  ?? throw new ArgumentNullException(nameof(productFinalUnitRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductFinalUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductFinalUnit>(request.UpdateProductFinalUnitDTO);
            return await _productFinalUnitRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}