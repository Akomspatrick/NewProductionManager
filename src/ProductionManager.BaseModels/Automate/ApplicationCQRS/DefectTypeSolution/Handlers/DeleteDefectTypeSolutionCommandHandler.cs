using ProductionManager.Domain.Interfaces;
using ProductionManager.Application.Contracts.Logging;
using ProductionManager.Application.CQRS.Model.Commands;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteDefectTypeSolutionCommandHandler  :  IRequestHandler<DeleteDefectTypeSolutionCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteDefectTypeSolutionCommandHandler> _logger;
        public DeleteDefectTypeSolutionCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteDefectTypeSolutionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteDefectTypeSolutionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}