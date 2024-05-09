using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateShuntResistorCommandHandler  :  IRequestHandler<CreateShuntResistorCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateShuntResistorCommandHandler> _logger;
        public IShuntResistorRepository _shuntResistorRepository ;
        public CreateShuntResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateShuntResistorCommandHandler> logger, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateShuntResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ShuntResistor.Create(request.shuntResistorCreateDTO.ShuntResistorName, request.shuntResistorCreateDTO.Value.GuidId);return ( await  _shuntResistorRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}