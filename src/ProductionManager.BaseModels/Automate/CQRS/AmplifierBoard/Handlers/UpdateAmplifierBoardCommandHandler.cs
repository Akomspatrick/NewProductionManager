using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateAmplifierBoardCommandHandler  :  IRequestHandler<UpdateAmplifierBoardCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateAmplifierBoardCommandHandler> _logger;
        public IAmplifierBoardRepository _amplifierBoardRepository ;
        private readonly IMapper _mapper;
        public UpdateAmplifierBoardCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateAmplifierBoardCommandHandler> logger, IMapper mapper, IAmplifierBoardRepository amplifierBoardRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _amplifierBoardRepository = amplifierBoardRepository  ?? throw new ArgumentNullException(nameof(amplifierBoardRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateAmplifierBoardCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.AmplifierBoard>(request.UpdateAmplifierBoardDTO);
            return await _amplifierBoardRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}