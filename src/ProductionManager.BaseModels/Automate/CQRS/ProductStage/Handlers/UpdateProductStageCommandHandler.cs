using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductStageCommandHandler  :  IRequestHandler<UpdateProductStageCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductStageCommandHandler> _logger;
        public IProductStageRepository _productStageRepository ;
        private readonly IMapper _mapper;
        public UpdateProductStageCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductStageCommandHandler> logger, IMapper mapper, IProductStageRepository productStageRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productStageRepository = productStageRepository  ?? throw new ArgumentNullException(nameof(productStageRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductStageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductStage>(request.UpdateProductStageDTO);
            return await _productStageRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}