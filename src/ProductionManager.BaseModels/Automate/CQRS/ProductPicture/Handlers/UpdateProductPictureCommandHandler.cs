using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateProductPictureCommandHandler  :  IRequestHandler<UpdateProductPictureCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProductPictureCommandHandler> _logger;
        public IProductPictureRepository _productPictureRepository ;
        private readonly IMapper _mapper;
        public UpdateProductPictureCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProductPictureCommandHandler> logger, IMapper mapper, IProductPictureRepository productPictureRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _productPictureRepository = productPictureRepository  ?? throw new ArgumentNullException(nameof(productPictureRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProductPictureCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProductPicture>(request.UpdateProductPictureDTO);
            return await _productPictureRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}