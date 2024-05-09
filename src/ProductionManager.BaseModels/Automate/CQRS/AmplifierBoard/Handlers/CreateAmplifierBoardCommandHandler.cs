using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Application.CQRS
{
    public  class CreateAmplifierBoardCommandHandler  :  IRequestHandler<CreateAmplifierBoardCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateAmplifierBoardCommandHandler> _logger;
        public IAmplifierBoardRepository _amplifierBoardRepository ;
        public CreateAmplifierBoardCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateAmplifierBoardCommandHandler> logger, IAmplifierBoardRepository amplifierBoardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _amplifierBoardRepository = amplifierBoardRepository  ?? throw new ArgumentNullException(nameof(amplifierBoardRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateAmplifierBoardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.AmplifierBoard.Create(request.amplifierBoardCreateDTO.AmplifierBoardName, request.amplifierBoardCreateDTO.Value.GuidId);return ( await  _amplifierBoardRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}