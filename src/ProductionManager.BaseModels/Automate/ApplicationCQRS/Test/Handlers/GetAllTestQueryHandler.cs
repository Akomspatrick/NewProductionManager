using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetAllTestQueryHandler  :  IRequestHandler<GetAllTestQuery, Either<GeneralFailure, IEnumerable<TestResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllTestQueryHandler> _logger;
        public GetAllTestQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllTestQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TestResponseDTO>>> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}