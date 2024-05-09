using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTrimmingResistorQueryHandler  :  IRequestHandler<GetAllTrimmingResistorQuery, Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllTrimmingResistorQueryHandler> _logger;
        public GetAllTrimmingResistorQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllTrimmingResistorQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>> Handle(GetAllTrimmingResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}