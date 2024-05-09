using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetShuntResistorByGuidQueryHandler  :  IRequestHandler<GetShuntResistorByGuidQuery, Either<GeneralFailure, ShuntResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetShuntResistorByGuidQueryHandler> _logger;
        public IShuntResistorRepository _shuntResistorRepository ;
        public GetShuntResistorByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetShuntResistorByGuidQueryHandler> logger, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, ShuntResistorResponseDTO>> Handle(GetShuntResistorByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}