using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetReferenceStandardByIdQueryHandler  :  IRequestHandler<GetReferenceStandardByIdQuery, Either<GeneralFailure, ReferenceStandardResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetReferenceStandardByIdQueryHandler> _logger;
        public GetReferenceStandardByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetReferenceStandardByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ReferenceStandardResponseDTO>> Handle(GetReferenceStandardByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}