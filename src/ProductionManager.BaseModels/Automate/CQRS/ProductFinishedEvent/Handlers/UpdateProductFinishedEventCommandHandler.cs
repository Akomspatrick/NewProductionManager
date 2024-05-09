using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductFinishedEventCommandHandler  :  IRequestHandler<UpdateProductFinishedEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductFinishedEventCommandHandler> _logger;
        public IProductFinishedEventRepository _productFinishedEventRepository ;
        private readonly IMapper _mapper;
        public UpdateProductFinishedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductFinishedEventCommandHandler> logger, IMapper mapper, IProductFinishedEventRepository productFinishedEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productFinishedEventRepository = productFinishedEventRepository  ?? throw new ArgumentNullException(nameof(productFinishedEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductFinishedEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductFinishedEvent>(request.UpdateProductFinishedEventDTO);
            return await _productFinishedEventRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}