using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateShuntResistorCommandHandler  :  IRequestHandler<UpdateShuntResistorCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateShuntResistorCommandHandler> _logger;
        public IShuntResistorRepository _shuntResistorRepository ;
        private readonly IMapper _mapper;
        public UpdateShuntResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateShuntResistorCommandHandler> logger, IMapper mapper, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateShuntResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ShuntResistor>(request.UpdateShuntResistorDTO);
            return await _shuntResistorRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}