using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateReferenceStandardCommandHandler  :  IRequestHandler<UpdateReferenceStandardCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateReferenceStandardCommandHandler> _logger;
        public IReferenceStandardRepository _referenceStandardRepository ;
        private readonly IMapper _mapper;
        public UpdateReferenceStandardCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateReferenceStandardCommandHandler> logger, IMapper mapper, IReferenceStandardRepository referenceStandardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _referenceStandardRepository = referenceStandardRepository  ?? throw new ArgumentNullException(nameof(referenceStandardRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateReferenceStandardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ReferenceStandard>(request.UpdateReferenceStandardDTO);
            return await _referenceStandardRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}