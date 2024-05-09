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
    public  class ProductShippingEventsController  : TheBaseController<ProductShippingEventsController>
    {

        public ProductShippingEventsController(ILogger<ProductShippingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductShippingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductShippingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductShippingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductShippingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductShippingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductShippingEventByGuidQuery(new ProductShippingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductShippingEventByIdQuery(new ProductShippingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductShippingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductShippingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductShippingEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductShippingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.Create)]
        public Task<IActionResult> Create(ProductShippingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductShippingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductShippingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductShippingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.Update)]
        public Task<IActionResult> Update(ProductShippingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductShippingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductShippingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductShippingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductShippingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductShippingEventCommand(new ProductShippingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}