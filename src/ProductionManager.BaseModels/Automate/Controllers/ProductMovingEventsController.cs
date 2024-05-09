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
                (_sender.Send(new GetProductMovingEventByGuidQuery(new ProductMovingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductMovingEventByIdQuery(new ProductMovingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductMovingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductMovingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductMovingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductMovingEventQuery(request), cancellationToken)) .ToActionResult404();

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