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
    public  class ProductCablingEventsController  : TheBaseController<ProductCablingEventsController>
    {

        public ProductCablingEventsController(ILogger<ProductCablingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductCablingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCablingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductCablingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductCablingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCablingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductCablingEventByGuidQuery(new ProductCablingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductCablingEventByIdQuery(new ProductCablingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductCablingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCablingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductCablingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductCablingEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductCablingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.Create)]
        public Task<IActionResult> Create(ProductCablingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductCablingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCablingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductCablingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.Update)]
        public Task<IActionResult> Update(ProductCablingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductCablingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCablingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductCablingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductCablingEventCommand(new ProductCablingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}