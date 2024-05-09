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
    public  class ProductVersionChangedEventsController  : TheBaseController<ProductVersionChangedEventsController>
    {

        public ProductVersionChangedEventsController(ILogger<ProductVersionChangedEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductVersionChangedEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Get, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductVersionChangedEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductVersionChangedEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductVersionChangedEventByGuidQuery(new ProductVersionChangedEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductVersionChangedEventByIdQuery(new ProductVersionChangedEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductVersionChangedEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductVersionChangedEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Create, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Create)]
        public Task<IActionResult> Create(ProductVersionChangedEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductVersionChangedEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Update, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Update)]
        public Task<IActionResult> Update(ProductVersionChangedEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductVersionChangedEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductVersionChangedEventCommand(new ProductVersionChangedEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}