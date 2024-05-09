using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS
{
    public  class DeleteShuntResistorCommandHandler  :  IRequestHandler<DeleteShuntResistorCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IShuntResistorRepository _shuntResistorRepository ;
        private readonly ILogger<DeleteShuntResistorCommandHandler> _logger;
        public DeleteShuntResistorCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteShuntResistorCommandHandler> logger, IShuntResistorRepository shuntResistorRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shuntResistorRepository = shuntResistorRepository  ?? throw new ArgumentNullException(nameof(shuntResistorRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteShuntResistorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _shuntResistorRepository.DeleteByGuidAsync(request.DeleteShuntResistorDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ShuntResistorRepository.DeleteByGuidAsync(request.DeleteShuntResistorDTO.guid, cancellationToken);
        }
    }
}