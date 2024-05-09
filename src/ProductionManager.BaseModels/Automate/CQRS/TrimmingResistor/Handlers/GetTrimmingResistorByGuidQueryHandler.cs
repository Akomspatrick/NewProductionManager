using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTrimmingResistorByGuidQueryHandler  :  IRequestHandler<GetTrimmingResistorByGuidQuery, Either<GeneralFailure, TrimmingResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTrimmingResistorByGuidQueryHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        public GetTrimmingResistorByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTrimmingResistorByGuidQueryHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, TrimmingResistorResponseDTO>> Handle(GetTrimmingResistorByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}