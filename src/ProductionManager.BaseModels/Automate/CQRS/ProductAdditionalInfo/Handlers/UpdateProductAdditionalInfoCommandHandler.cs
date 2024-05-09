using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductAdditionalInfoCommandHandler  :  IRequestHandler<UpdateProductAdditionalInfoCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductAdditionalInfoCommandHandler> _logger;
        public IProductAdditionalInfoRepository _productAdditionalInfoRepository ;
        private readonly IMapper _mapper;
        public UpdateProductAdditionalInfoCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductAdditionalInfoCommandHandler> logger, IMapper mapper, IProductAdditionalInfoRepository productAdditionalInfoRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productAdditionalInfoRepository = productAdditionalInfoRepository  ?? throw new ArgumentNullException(nameof(productAdditionalInfoRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductAdditionalInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductAdditionalInfo>(request.UpdateProductAdditionalInfoDTO);
            return await _productAdditionalInfoRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}