using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateDefectTypeCommandHandler  :  IRequestHandler<UpdateDefectTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateDefectTypeCommandHandler> _logger;
        public IDefectTypeRepository _defectTypeRepository ;
        private readonly IMapper _mapper;
        public UpdateDefectTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateDefectTypeCommandHandler> logger, IMapper mapper, IDefectTypeRepository defectTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _defectTypeRepository = defectTypeRepository  ?? throw new ArgumentNullException(nameof(defectTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateDefectTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.DefectType>(request.UpdateDefectTypeDTO);
            return await _defectTypeRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}