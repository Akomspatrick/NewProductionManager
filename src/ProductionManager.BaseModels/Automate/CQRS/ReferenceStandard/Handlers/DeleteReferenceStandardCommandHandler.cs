using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteReferenceStandardCommandHandler  :  IRequestHandler<DeleteReferenceStandardCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IReferenceStandardRepository _referenceStandardRepository ;
        private readonly ILogger<DeleteReferenceStandardCommandHandler> _logger;
        public DeleteReferenceStandardCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteReferenceStandardCommandHandler> logger, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteReferenceStandardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _referenceStandardRepository.DeleteByGuidAsync(request.DeleteReferenceStandardDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ReferenceStandardRepository.DeleteByGuidAsync(request.DeleteReferenceStandardDTO.guid, cancellationToken);
        }
    }
}