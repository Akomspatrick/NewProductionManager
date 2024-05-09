using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassLoadApplicationByGuidQueryHandler  :  IRequestHandler<GetMassLoadApplicationByGuidQuery, Either<GeneralFailure, MassLoadApplicationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassLoadApplicationByGuidQueryHandler> _logger;
        public GetMassLoadApplicationByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassLoadApplicationByGuidQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassLoadApplicationResponseDTO>> Handle(GetMassLoadApplicationByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}