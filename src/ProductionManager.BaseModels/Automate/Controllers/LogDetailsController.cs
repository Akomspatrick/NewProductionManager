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
    public  class LogDetailsController  : TheBaseController<LogDetailsController>
    {

        public LogDetailsController(ILogger<LogDetailsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<LogDetailResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogDetail.Get, Name = ProductionManagerAPIEndPoints.LogDetail.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllLogDetailQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(LogDetailResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogDetail.GetById, Name = ProductionManagerAPIEndPoints.LogDetail.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetLogDetailByGuidQuery(new LogDetailGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetLogDetailByIdQuery(new LogDetailGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(LogDetailResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogDetail.GetByJSONBody, Name = ProductionManagerAPIEndPoints.LogDetail.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] LogDetailGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetLogDetailQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.LogDetail.Create, Name = ProductionManagerAPIEndPoints.LogDetail.Create)]
        public Task<IActionResult> Create(LogDetailCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateLogDetailCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.LogDetail.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.LogDetail.Update, Name = ProductionManagerAPIEndPoints.LogDetail.Update)]
        public Task<IActionResult> Update(LogDetailUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateLogDetailCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.LogDetail.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.LogDetail.Delete, Name = ProductionManagerAPIEndPoints.LogDetail.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteLogDetailCommand(new LogDetailDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}