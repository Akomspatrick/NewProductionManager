using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateReferenceStandardCommandHandler  :  IRequestHandler<CreateReferenceStandardCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateReferenceStandardCommandHandler> _logger;
        public IReferenceStandardRepository _referenceStandardRepository ;
        public CreateReferenceStandardCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateReferenceStandardCommandHandler> logger, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateReferenceStandardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ReferenceStandard.Create(request.referenceStandardCreateDTO.ReferenceStandardName, request.referenceStandardCreateDTO.Value.GuidId);return ( await  _referenceStandardRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}