using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllShuntResistorQueryHandler  :  IRequestHandler<GetAllShuntResistorQuery, Either<GeneralFailure, IEnumerable<ShuntResistorResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllShuntResistorQueryHandler> _logger;
        public IShuntResistorRepository _shuntResistorRepository ;
        public GetAllShuntResistorQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllShuntResistorQueryHandler> logger, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ShuntResistorResponseDTO>>> Handle(GetAllShuntResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}