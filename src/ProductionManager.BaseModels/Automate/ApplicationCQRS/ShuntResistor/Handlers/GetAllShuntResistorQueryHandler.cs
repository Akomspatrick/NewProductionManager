using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllShuntResistorQueryHandler  :  IRequestHandler<GetAllShuntResistorQuery, Either<GeneralFailure, IEnumerable<ShuntResistorResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllShuntResistorQueryHandler> _logger;
        public GetAllShuntResistorQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllShuntResistorQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ShuntResistorResponseDTO>>> Handle(GetAllShuntResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}