using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteAmplifierBoardCommandHandler  :  IRequestHandler<DeleteAmplifierBoardCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IAmplifierBoardRepository _amplifierBoardRepository ;
        private readonly ILogger<DeleteAmplifierBoardCommandHandler> _logger;
        public DeleteAmplifierBoardCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteAmplifierBoardCommandHandler> logger, IAmplifierBoardRepository amplifierBoardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _amplifierBoardRepository = amplifierBoardRepository  ?? throw new ArgumentNullException(nameof(amplifierBoardRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteAmplifierBoardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _amplifierBoardRepository.DeleteByGuidAsync(request.DeleteAmplifierBoardDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.AmplifierBoardRepository.DeleteByGuidAsync(request.DeleteAmplifierBoardDTO.guid, cancellationToken);
        }
    }
}