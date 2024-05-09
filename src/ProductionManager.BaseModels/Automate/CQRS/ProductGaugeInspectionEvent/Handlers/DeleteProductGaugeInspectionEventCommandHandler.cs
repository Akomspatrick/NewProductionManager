using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteProductGaugeInspectionEventCommandHandler  :  IRequestHandler<DeleteProductGaugeInspectionEventCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProductGaugeInspectionEventRepository _productGaugeInspectionEventRepository ;
        private readonly ILogger<DeleteProductGaugeInspectionEventCommandHandler> _logger;
        public DeleteProductGaugeInspectionEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProductGaugeInspectionEventCommandHandler> logger, IProductGaugeInspectionEventRepository productGaugeInspectionEventRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _productGaugeInspectionEventRepository = productGaugeInspectionEventRepository  ?? throw new ArgumentNullException(nameof(productGaugeInspectionEventRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProductGaugeInspectionEventCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _productGaugeInspectionEventRepository.DeleteByGuidAsync(request.DeleteProductGaugeInspectionEventDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProductGaugeInspectionEventRepository.DeleteByGuidAsync(request.DeleteProductGaugeInspectionEventDTO.guid, cancellationToken);
        }
    }
}