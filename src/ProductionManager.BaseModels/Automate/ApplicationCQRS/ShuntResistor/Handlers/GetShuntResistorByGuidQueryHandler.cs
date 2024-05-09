using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetShuntResistorByGuidQueryHandler  :  IRequestHandler<GetShuntResistorByGuidQuery, Either<GeneralFailure, ShuntResistorResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetShuntResistorByGuidQueryHandler> _logger;
        public GetShuntResistorByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetShuntResistorByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ShuntResistorResponseDTO>> Handle(GetShuntResistorByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}