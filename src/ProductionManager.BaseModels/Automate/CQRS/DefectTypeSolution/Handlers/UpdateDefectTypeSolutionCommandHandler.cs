using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateDefectTypeSolutionCommandHandler  :  IRequestHandler<UpdateDefectTypeSolutionCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateDefectTypeSolutionCommandHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        private readonly IMapper _mapper;
        public UpdateDefectTypeSolutionCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateDefectTypeSolutionCommandHandler> logger, IMapper mapper, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateDefectTypeSolutionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.DefectTypeSolution>(request.UpdateDefectTypeSolutionDTO);
            return await _defectTypeSolutionRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}