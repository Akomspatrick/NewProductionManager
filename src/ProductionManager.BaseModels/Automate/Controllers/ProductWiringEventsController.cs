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
    public  class ProductWiringEventsController  : TheBaseController<ProductWiringEventsController>
    {

        public ProductWiringEventsController(ILogger<ProductWiringEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductWiringEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductWiringEvent.Get, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductWiringEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductWiringEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductWiringEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductWiringEventByGuidQuery(new ProductWiringEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductWiringEventByIdQuery(new ProductWiringEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductWiringEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductWiringEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductWiringEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductWiringEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductWiringEvent.Create, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.Create)]
        public Task<IActionResult> Create(ProductWiringEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductWiringEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductWiringEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductWiringEvent.Update, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.Update)]
        public Task<IActionResult> Update(ProductWiringEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductWiringEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductWiringEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductWiringEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductWiringEventCommand(new ProductWiringEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}