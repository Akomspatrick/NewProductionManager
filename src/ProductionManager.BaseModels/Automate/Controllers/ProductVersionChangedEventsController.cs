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
                (_sender.Send(new GetProductVersionChangedEventByGuidQuery(new ProductVersionChangedEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductVersionChangedEventByIdQuery(new ProductVersionChangedEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductVersionChangedEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductVersionChangedEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductVersionChangedEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductVersionChangedEventQuery(request), cancellationToken)) .ToEitherActionResult();

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