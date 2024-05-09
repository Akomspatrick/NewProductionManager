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
    public  class LogSummarysController  : TheBaseController<LogSummarysController>
    {

        public LogSummarysController(ILogger<LogSummarysController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<LogSummaryResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogSummary.Get, Name = ProductionManagerAPIEndPoints.LogSummary.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllLogSummaryQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(LogSummaryResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogSummary.GetById, Name = ProductionManagerAPIEndPoints.LogSummary.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetLogSummaryByGuidQuery(new LogSummaryGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetLogSummaryByIdQuery(new LogSummaryGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(LogSummaryResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogSummary.GetByJSONBody, Name = ProductionManagerAPIEndPoints.LogSummary.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] LogSummaryGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetLogSummaryQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.LogSummary.Create, Name = ProductionManagerAPIEndPoints.LogSummary.Create)]
        public Task<IActionResult> Create(LogSummaryCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateLogSummaryCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.LogSummary.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.LogSummary.Update, Name = ProductionManagerAPIEndPoints.LogSummary.Update)]
        public Task<IActionResult> Update(LogSummaryUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateLogSummaryCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.LogSummary.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.LogSummary.Delete, Name = ProductionManagerAPIEndPoints.LogSummary.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteLogSummaryCommand(new LogSummaryDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}