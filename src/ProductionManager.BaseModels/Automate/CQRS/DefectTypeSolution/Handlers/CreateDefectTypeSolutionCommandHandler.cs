using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateDefectTypeSolutionCommandHandler  :  IRequestHandler<CreateDefectTypeSolutionCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateDefectTypeSolutionCommandHandler> _logger;
        public IDefectTypeSolutionRepository _defectTypeSolutionRepository ;
        public CreateDefectTypeSolutionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateDefectTypeSolutionCommandHandler> logger, IDefectTypeSolutionRepository defectTypeSolutionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _defectTypeSolutionRepository = defectTypeSolutionRepository  ?? throw new ArgumentNullException(nameof(defectTypeSolutionRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateDefectTypeSolutionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.DefectTypeSolution.Create(request.defectTypeSolutionCreateDTO.DefectTypeSolutionName, request.defectTypeSolutionCreateDTO.Value.GuidId);return ( await  _defectTypeSolutionRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}