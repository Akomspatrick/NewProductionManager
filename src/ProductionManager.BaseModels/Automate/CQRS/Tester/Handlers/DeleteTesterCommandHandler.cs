using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteTesterCommandHandler  :  IRequestHandler<DeleteTesterCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ITesterRepository _testerRepository ;
        private readonly ILogger<DeleteTesterCommandHandler> _logger;
        public DeleteTesterCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteTesterCommandHandler> logger, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteTesterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _testerRepository.DeleteByGuidAsync(request.DeleteTesterDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.TesterRepository.DeleteByGuidAsync(request.DeleteTesterDTO.guid, cancellationToken);
        }
    }
}