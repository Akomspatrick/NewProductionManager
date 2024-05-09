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
    public  class ProductFinishedEventsController  : TheBaseController<ProductFinishedEventsController>
    {

        public ProductFinishedEventsController(ILogger<ProductFinishedEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductFinishedEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.Get, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductFinishedEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductFinishedEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductFinishedEventByGuidQuery(new ProductFinishedEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductFinishedEventByIdQuery(new ProductFinishedEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductFinishedEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductFinishedEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductFinishedEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.Create, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.Create)]
        public Task<IActionResult> Create(ProductFinishedEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductFinishedEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinishedEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.Update, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.Update)]
        public Task<IActionResult> Update(ProductFinishedEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductFinishedEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinishedEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductFinishedEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductFinishedEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductFinishedEventCommand(new ProductFinishedEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}