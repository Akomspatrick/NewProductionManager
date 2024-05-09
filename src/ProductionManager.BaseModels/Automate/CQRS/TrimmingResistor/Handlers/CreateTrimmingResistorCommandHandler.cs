using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateTrimmingResistorCommandHandler  :  IRequestHandler<CreateTrimmingResistorCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTrimmingResistorCommandHandler> _logger;
        public ITrimmingResistorRepository _trimmingResistorRepository ;
        public CreateTrimmingResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTrimmingResistorCommandHandler> logger, ITrimmingResistorRepository trimmingResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _trimmingResistorRepository = trimmingResistorRepository  ?? throw new ArgumentNullException(nameof(trimmingResistorRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTrimmingResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.TrimmingResistor.Create(request.trimmingResistorCreateDTO.TrimmingResistorName, request.trimmingResistorCreateDTO.Value.GuidId);return ( await  _trimmingResistorRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}