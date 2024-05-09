using ProductionManager.Api.Extentions;
using ProductionManager.Application.CQRS;
using ProductionManager.Contracts.RequestDTO;
using ProductionManager.Contracts.ResponseDTO;
using ProductionManager.Api.Extensions;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
namespace ProductionManager.Api.Controllers.v1
{
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
                (_sender.Send(new GetNonConformanceLogByGuidQuery(new NonConformanceLogGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetNonConformanceLogByIdQuery(new NonConformanceLogGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.NonConformanceLog.GetByJSONBody, Name = ProductionManagerAPIEndPoints.NonConformanceLog.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] NonConformanceLogGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetNonConformanceLogQuery(request), cancellationToken)) .ToActionResult404();

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