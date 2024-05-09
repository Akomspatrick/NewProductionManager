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
                (_sender.Send(new GetProductInventoryEventByGuidQuery(new ProductInventoryEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductInventoryEventByIdQuery(new ProductInventoryEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductInventoryEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInventoryEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductInventoryEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductInventoryEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductInventoryEventQuery(request), cancellationToken)) .ToEitherActionResult();

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