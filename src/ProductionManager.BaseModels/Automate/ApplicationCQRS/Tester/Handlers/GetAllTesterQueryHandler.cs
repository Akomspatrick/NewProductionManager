using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTesterQueryHandler  :  IRequestHandler<GetAllTesterQuery, Either<GeneralFailure, IEnumerable<TesterResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllTesterQueryHandler> _logger;
        public GetAllTesterQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllTesterQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TesterResponseDTO>>> Handle(GetAllTesterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}