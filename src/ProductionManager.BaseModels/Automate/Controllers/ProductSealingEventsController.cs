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
    public  class ProductSealingEventsController  : TheBaseController<ProductSealingEventsController>
    {

        public ProductSealingEventsController(ILogger<ProductSealingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductSealingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSealingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductSealingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductSealingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSealingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductSealingEventByGuidQuery(new ProductSealingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductSealingEventByIdQuery(new ProductSealingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductSealingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductSealingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductSealingEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductSealingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.Create)]
        public Task<IActionResult> Create(ProductSealingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductSealingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductSealingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductSealingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.Update)]
        public Task<IActionResult> Update(ProductSealingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductSealingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductSealingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductSealingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductSealingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductSealingEventCommand(new ProductSealingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}