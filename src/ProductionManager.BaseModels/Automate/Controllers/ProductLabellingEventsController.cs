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
    public  class ProductLabellingEventsController  : TheBaseController<ProductLabellingEventsController>
    {

        public ProductLabellingEventsController(ILogger<ProductLabellingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductLabellingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductLabellingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductLabellingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductLabellingEventByGuidQuery(new ProductLabellingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductLabellingEventByIdQuery(new ProductLabellingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductLabellingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductLabellingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductLabellingEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Create)]
        public Task<IActionResult> Create(ProductLabellingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductLabellingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductLabellingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Update)]
        public Task<IActionResult> Update(ProductLabellingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductLabellingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductLabellingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductLabellingEventCommand(new ProductLabellingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}