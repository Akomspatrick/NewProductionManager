using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Queries;
using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class GetDefectTypeByIdQueryHandler  :  IRequestHandler<GetDefectTypeByIdQuery, Either<GeneralFailure, DefectTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetDefectTypeByIdQueryHandler> _logger;
        public GetDefectTypeByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetDefectTypeByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, DefectTypeResponseDTO>> Handle(GetDefectTypeByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}