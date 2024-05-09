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
                (_sender.Send(new GetLogDetailByGuidQuery(new LogDetailGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetLogDetailByIdQuery(new LogDetailGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.LogDetail.GetByJSONBody, Name = ProductionManagerAPIEndPoints.LogDetail.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] LogDetailGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetLogDetailQuery(request), cancellationToken)) .ToActionResult404();

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