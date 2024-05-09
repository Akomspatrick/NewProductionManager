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
    public  class ProductFinalVerifiationEventsController  : TheBaseController<ProductFinalVerifiationEventsController>
    {

        public ProductFinalVerifiationEventsController(ILogger<ProductFinalVerifiationEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductFinalVerifiationEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Get, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductFinalVerifiationEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductFinalVerifiationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductFinalVerifiationEventByGuidQuery(new ProductFinalVerifiationEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductFinalVerifiationEventByIdQuery(new ProductFinalVerifiationEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductFinalVerifiationEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductFinalVerifiationEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Create, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Create)]
        public Task<IActionResult> Create(ProductFinalVerifiationEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductFinalVerifiationEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Update, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Update)]
        public Task<IActionResult> Update(ProductFinalVerifiationEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductFinalVerifiationEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductFinalVerifiationEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductFinalVerifiationEventCommand(new ProductFinalVerifiationEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}