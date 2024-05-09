using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetMassLoadApplicationByIdQueryHandler  :  IRequestHandler<GetMassLoadApplicationByIdQuery, Either<GeneralFailure, MassLoadApplicationResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetMassLoadApplicationByIdQueryHandler> _logger;
        public GetMassLoadApplicationByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetMassLoadApplicationByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, MassLoadApplicationResponseDTO>> Handle(GetMassLoadApplicationByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}