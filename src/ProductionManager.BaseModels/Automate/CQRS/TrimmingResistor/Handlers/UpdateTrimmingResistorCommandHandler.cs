using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateTrimmingResistorCommandHandler  :  IRequestHandler<UpdateTrimmingResistorCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateTrimmingResistorCommandHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        private readonly IMapper _mapper;
        public UpdateTrimmingResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateTrimmingResistorCommandHandler> logger, IMapper mapper, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateTrimmingResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.TrimmingResistor>(request.UpdateTrimmingResistorDTO);
            return await _trimmingResistorRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}