using ProductionManager.Api.Extensions;
using ProductionManager.Application.CQRS;
using Asp.Versioning;
using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using MediatR;
using ProductionManager.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
namespace ProductionManager.Api.Controllers.V1
{
     [ApiVersion(1)]
    public  class NonConformanceLogsController  : TheBaseController<NonConformanceLogsController>
    {

        public NonConformanceLogsController(ILogger<NonConformanceLogsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<NonConformanceLogResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.NonConformanceLog.Get, Name = ProductionManagerAPIEndPoints.NonConformanceLog.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllNonConformanceLogQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(NonConformanceLogResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.NonConformanceLog.GetById, Name = ProductionManagerAPIEndPoints.NonConformanceLog.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetNonConformanceLogByGuidQuery(new NonConformanceLogGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetNonConformanceLogByIdQuery(new NonConformanceLogGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(NonConformanceLogResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.NonConformanceLog.GetByJSONBody, Name = ProductionManagerAPIEndPoints.NonConformanceLog.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] NonConformanceLogGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetNonConformanceLogQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.NonConformanceLog.Create, Name = ProductionManagerAPIEndPoints.NonConformanceLog.Create)]
        public Task<IActionResult> Create(NonConformanceLogCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateNonConformanceLogCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.NonConformanceLog.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.NonConformanceLog.Update, Name = ProductionManagerAPIEndPoints.NonConformanceLog.Update)]
        public Task<IActionResult> Update(NonConformanceLogUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateNonConformanceLogCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.NonConformanceLog.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.NonConformanceLog.Delete, Name = ProductionManagerAPIEndPoints.NonConformanceLog.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteNonConformanceLogCommand(new NonConformanceLogDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}