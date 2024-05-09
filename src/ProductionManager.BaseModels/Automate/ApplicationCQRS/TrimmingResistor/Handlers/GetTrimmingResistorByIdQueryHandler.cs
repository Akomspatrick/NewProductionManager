using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetTrimmingResistorByIdQueryHandler  :  IRequestHandler<GetTrimmingResistorByIdQuery, Either<GeneralFailure, TrimmingResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTrimmingResistorByIdQueryHandler> _logger;
        public GetTrimmingResistorByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTrimmingResistorByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, TrimmingResistorResponseDTO>> Handle(GetTrimmingResistorByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}