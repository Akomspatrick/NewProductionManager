using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateNonConformanceLogCommandHandler  :  IRequestHandler<UpdateNonConformanceLogCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateNonConformanceLogCommandHandler> _logger;
        public INonConformanceLogRepository _nonConformanceLogRepository ;
        private readonly IMapper _mapper;
        public UpdateNonConformanceLogCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateNonConformanceLogCommandHandler> logger, IMapper mapper, INonConformanceLogRepository nonConformanceLogRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _nonConformanceLogRepository = nonConformanceLogRepository  ?? throw new ArgumentNullException(nameof(nonConformanceLogRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateNonConformanceLogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.NonConformanceLog>(request.UpdateNonConformanceLogDTO);
            return await _nonConformanceLogRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}