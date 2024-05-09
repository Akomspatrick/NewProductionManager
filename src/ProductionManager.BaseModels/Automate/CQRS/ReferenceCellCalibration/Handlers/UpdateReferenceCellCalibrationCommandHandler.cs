using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateReferenceCellCalibrationCommandHandler  :  IRequestHandler<UpdateReferenceCellCalibrationCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateReferenceCellCalibrationCommandHandler> _logger;
        public IReferenceCellCalibrationRepository _referenceCellCalibrationRepository ;
        private readonly IMapper _mapper;
        public UpdateReferenceCellCalibrationCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateReferenceCellCalibrationCommandHandler> logger, IMapper mapper, IReferenceCellCalibrationRepository referenceCellCalibrationRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _referenceCellCalibrationRepository = referenceCellCalibrationRepository  ?? throw new ArgumentNullException(nameof(referenceCellCalibrationRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateReferenceCellCalibrationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ReferenceCellCalibration>(request.UpdateReferenceCellCalibrationDTO);
            return await _referenceCellCalibrationRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}