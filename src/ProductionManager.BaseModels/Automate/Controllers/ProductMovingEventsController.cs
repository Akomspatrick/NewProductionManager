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
    public  class ProductMovingEventsController  : TheBaseController<ProductMovingEventsController>
    {

        public ProductMovingEventsController(ILogger<ProductMovingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductMovingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductMovingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductMovingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductMovingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductMovingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductMovingEventByGuidQuery(new ProductMovingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductMovingEventByIdQuery(new ProductMovingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductMovingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductMovingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductMovingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductMovingEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductMovingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.Create)]
        public Task<IActionResult> Create(ProductMovingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductMovingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductMovingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductMovingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.Update)]
        public Task<IActionResult> Update(ProductMovingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductMovingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductMovingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductMovingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductMovingEventCommand(new ProductMovingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}