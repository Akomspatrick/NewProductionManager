using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTrimmingResistorByIdQueryHandler  :  IRequestHandler<GetTrimmingResistorByIdQuery, Either<GeneralFailure, TrimmingResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTrimmingResistorByIdQueryHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        public GetTrimmingResistorByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTrimmingResistorByIdQueryHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, TrimmingResistorResponseDTO>> Handle(GetTrimmingResistorByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}