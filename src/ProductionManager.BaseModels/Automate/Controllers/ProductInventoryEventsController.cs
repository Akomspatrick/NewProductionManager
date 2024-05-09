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
    public  class ProductInventoryEventsController  : TheBaseController<ProductInventoryEventsController>
    {

        public ProductInventoryEventsController(ILogger<ProductInventoryEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductInventoryEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.Get, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductInventoryEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductInventoryEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductInventoryEventByGuidQuery(new ProductInventoryEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductInventoryEventByIdQuery(new ProductInventoryEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductInventoryEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductInventoryEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.Create, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.Create)]
        public Task<IActionResult> Create(ProductInventoryEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductInventoryEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInventoryEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.Update, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.Update)]
        public Task<IActionResult> Update(ProductInventoryEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductInventoryEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInventoryEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductInventoryEventCommand(new ProductInventoryEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}