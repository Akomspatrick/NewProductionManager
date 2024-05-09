using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllReferenceStandardQueryHandler  :  IRequestHandler<GetAllReferenceStandardQuery, Either<GeneralFailure, IEnumerable<ReferenceStandardResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllReferenceStandardQueryHandler> _logger;
        public GetAllReferenceStandardQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllReferenceStandardQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ReferenceStandardResponseDTO>>> Handle(GetAllReferenceStandardQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}