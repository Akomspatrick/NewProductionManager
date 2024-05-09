using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetShuntResistorQueryHandler  :  IRequestHandler<GetShuntResistorQuery, Either<GeneralFailure, ShuntResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetShuntResistorQueryHandler> _logger;
        public IShuntResistorRepository _shuntResistorRepository ;
        public GetShuntResistorQueryHandler(IUnitOfWork unitOfWork, ILogger<GetShuntResistorQueryHandler> logger, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, ShuntResistorResponseDTO>> Handle(GetShuntResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}