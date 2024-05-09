using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateModelVersionCommandHandler  :  IRequestHandler<UpdateModelVersionCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateModelVersionCommandHandler> _logger;
        public IModelVersionRepository _modelVersionRepository ;
        private readonly IMapper _mapper;
        public UpdateModelVersionCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateModelVersionCommandHandler> logger, IMapper mapper, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelVersionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ModelVersion>(request.UpdateModelVersionDTO);
            return await _modelVersionRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}