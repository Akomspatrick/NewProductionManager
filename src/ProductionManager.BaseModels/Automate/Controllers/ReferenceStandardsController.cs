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
    public  class ReferenceStandardsController  : TheBaseController<ReferenceStandardsController>
    {

        public ReferenceStandardsController(ILogger<ReferenceStandardsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ReferenceStandardResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceStandard.Get, Name = ProductionManagerAPIEndPoints.ReferenceStandard.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllReferenceStandardQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ReferenceStandardResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceStandard.GetById, Name = ProductionManagerAPIEndPoints.ReferenceStandard.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetReferenceStandardByGuidQuery(new ReferenceStandardGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetReferenceStandardByIdQuery(new ReferenceStandardGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceStandard.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ReferenceStandard.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ReferenceStandardGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetReferenceStandardQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ReferenceStandard.Create, Name = ProductionManagerAPIEndPoints.ReferenceStandard.Create)]
        public Task<IActionResult> Create(ReferenceStandardCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateReferenceStandardCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ReferenceStandard.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ReferenceStandard.Update, Name = ProductionManagerAPIEndPoints.ReferenceStandard.Update)]
        public Task<IActionResult> Update(ReferenceStandardUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateReferenceStandardCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ReferenceStandard.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ReferenceStandard.Delete, Name = ProductionManagerAPIEndPoints.ReferenceStandard.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteReferenceStandardCommand(new ReferenceStandardDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}