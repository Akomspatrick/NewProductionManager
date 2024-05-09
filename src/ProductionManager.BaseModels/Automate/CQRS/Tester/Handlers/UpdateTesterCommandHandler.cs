using ProductionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using ProductionManager.Domain.Errors;
using ProductionManager.Contracts.ResponseDTO.V1;
namespace ProductionManager.Application.CQRS
{
    public  class UpdateTesterCommandHandler  :  IRequestHandler<UpdateTesterCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateTesterCommandHandler> _logger;
        public ITesterRepository _testerRepository ;
        private readonly IMapper _mapper;
        public UpdateTesterCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateTesterCommandHandler> logger, IMapper mapper, ITesterRepository testerRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _testerRepository = testerRepository  ?? throw new ArgumentNullException(nameof(testerRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateTesterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.Tester>(request.UpdateTesterDTO);
            return await _testerRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}