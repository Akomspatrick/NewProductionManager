using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductCablingEventCommandHandler  :  IRequestHandler<UpdateProductCablingEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductCablingEventCommandHandler> _logger;
        public IProductCablingEventRepository _productCablingEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductCablingEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductCablingEventCommandHandler> logger, IMapper mapper, IProductCablingEventRepository productCablingEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productCablingEventRepository = productCablingEventRepository  ?? throw new ArgumentNullException(nameof(productCablingEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductCablingEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductCablingEvent>(request.UpdateProductCablingEventDTO);
            return await _productCablingEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}