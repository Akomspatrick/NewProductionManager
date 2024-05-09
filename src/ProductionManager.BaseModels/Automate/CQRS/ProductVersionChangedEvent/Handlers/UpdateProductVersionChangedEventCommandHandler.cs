using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductVersionChangedEventCommandHandler  :  IRequestHandler<UpdateProductVersionChangedEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductVersionChangedEventCommandHandler> _logger;
        public IProductVersionChangedEventRepository _productVersionChangedEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductVersionChangedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductVersionChangedEventCommandHandler> logger, IMapper mapper, IProductVersionChangedEventRepository productVersionChangedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productVersionChangedEventRepository = productVersionChangedEventRepository  ?? throw new ArgumentNullException(nameof(productVersionChangedEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductVersionChangedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductVersionChangedEvent>(request.UpdateProductVersionChangedEventDTO);
            return await _productVersionChangedEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}