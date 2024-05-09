using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateLogDetailCommandHandler  :  IRequestHandler<UpdateLogDetailCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateLogDetailCommandHandler> _logger;
        public ILogDetailRepository _logDetailRepository ;
        private readonly IMapper _mapper;
        public UpdateLogDetailCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateLogDetailCommandHandler> logger, IMapper mapper, ILogDetailRepository logDetailRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logDetailRepository = logDetailRepository  ?? throw new ArgumentNullException(nameof(logDetailRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateLogDetailCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.LogDetail>(request.UpdateLogDetailDTO);
            return await _logDetailRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}