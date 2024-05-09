using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTrimmingResistorQueryHandler  :  IRequestHandler<GetTrimmingResistorQuery, Either<GeneralFailure, TrimmingResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTrimmingResistorQueryHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        public GetTrimmingResistorQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTrimmingResistorQueryHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, TrimmingResistorResponseDTO>> Handle(GetTrimmingResistorQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}