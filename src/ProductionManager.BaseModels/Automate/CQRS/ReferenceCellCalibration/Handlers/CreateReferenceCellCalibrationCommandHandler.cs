using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateReferenceCellCalibrationCommandHandler  :  IRequestHandler<CreateReferenceCellCalibrationCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateReferenceCellCalibrationCommandHandler> _logger;
        public IReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        public CreateReferenceCellCalibrationCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateReferenceCellCalibrationCommandHandler> logger, IReferenceCellCalibrationRepository referenceCellCalibrationRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceCellCalibrationRepository = referenceCellCalibrationRepository  ?? throw new ArgumentNullException(nameof(referenceCellCalibrationRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateReferenceCellCalibrationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ReferenceCellCalibration.Create(request.referenceCellCalibrationCreateDTO.ReferenceCellCalibrationName, request.referenceCellCalibrationCreateDTO.Value.GuidId);return ( await  _referenceCellCalibrationRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}