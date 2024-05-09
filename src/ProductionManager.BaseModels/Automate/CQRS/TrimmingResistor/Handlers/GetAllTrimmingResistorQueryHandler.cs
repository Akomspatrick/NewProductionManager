using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTrimmingResistorQueryHandler  :  IRequestHandler<GetAllTrimmingResistorQuery, Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllTrimmingResistorQueryHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        public GetAllTrimmingResistorQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllTrimmingResistorQueryHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TrimmingResistorResponseDTO>>> Handle(GetAllTrimmingResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}