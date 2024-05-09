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
    public  class ProductGaugeEventsController  : TheBaseController<ProductGaugeEventsController>
    {

        public ProductGaugeEventsController(ILogger<ProductGaugeEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductGaugeEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.Get, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductGaugeEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductGaugeEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductGaugeEventByGuidQuery(new ProductGaugeEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductGaugeEventByIdQuery(new ProductGaugeEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductGaugeEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductGaugeEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductGaugeEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.Create, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.Create)]
        public Task<IActionResult> Create(ProductGaugeEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductGaugeEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductGaugeEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.Update, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.Update)]
        public Task<IActionResult> Update(ProductGaugeEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductGaugeEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductGaugeEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductGaugeEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductGaugeEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductGaugeEventCommand(new ProductGaugeEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}