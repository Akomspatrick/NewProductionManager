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
    public  class ProductSurfacePreparationEventsController  : TheBaseController<ProductSurfacePreparationEventsController>
    {

        public ProductSurfacePreparationEventsController(ILogger<ProductSurfacePreparationEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductSurfacePreparationEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Get, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductSurfacePreparationEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductSurfacePreparationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductSurfacePreparationEventByGuidQuery(new ProductSurfacePreparationEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductSurfacePreparationEventByIdQuery(new ProductSurfacePreparationEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductSurfacePreparationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductSurfacePreparationEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductSurfacePreparationEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Create, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Create)]
        public Task<IActionResult> Create(ProductSurfacePreparationEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductSurfacePreparationEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Update, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Update)]
        public Task<IActionResult> Update(ProductSurfacePreparationEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductSurfacePreparationEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductSurfacePreparationEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductSurfacePreparationEventCommand(new ProductSurfacePreparationEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}