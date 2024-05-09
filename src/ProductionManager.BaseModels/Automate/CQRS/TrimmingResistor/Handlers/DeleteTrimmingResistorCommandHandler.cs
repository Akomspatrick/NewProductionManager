using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteTrimmingResistorCommandHandler  :  IRequestHandler<DeleteTrimmingResistorCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        private readonly ILogger<DeleteTrimmingResistorCommandHandler> _logger;
        public DeleteTrimmingResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteTrimmingResistorCommandHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteTrimmingResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _trimmingResistorRepository.DeleteByGuidAsync(request.DeleteTrimmingResistorDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.TrimmingResistorRepository.DeleteByGuidAsync(request.DeleteTrimmingResistorDTO.guid, cancellationToken);
        }
    }
}