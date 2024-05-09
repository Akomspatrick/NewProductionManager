using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateReferenceCellCalibrationCommandHandler  :  IRequestHandler<CreateReferenceCellCalibrationCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateReferenceCellCalibrationCommandHandler> _logger;
        public CreateReferenceCellCalibrationCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateReferenceCellCalibrationCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateReferenceCellCalibrationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ReferenceCellCalibration.Create(request.modelTypeCreateDTO.ModelTypeName, request.modelTypeCreateDTO.Value.GuidId);return ( await _unitOfWork.ReferenceCellCalibrationRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}