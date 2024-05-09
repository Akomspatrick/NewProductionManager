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
    public  class ProductGaugeInspectionEventsController  : TheBaseController<ProductGaugeInspectionEventsController>
    {

        public ProductGaugeInspectionEventsController(ILogger<ProductGaugeInspectionEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductGaugeInspectionEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Get, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductGaugeInspectionEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductGaugeInspectionEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductGaugeInspectionEventByGuidQuery(new ProductGaugeInspectionEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductGaugeInspectionEventByIdQuery(new ProductGaugeInspectionEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductGaugeInspectionEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductGaugeInspectionEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductGaugeInspectionEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Create, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Create)]
        public Task<IActionResult> Create(ProductGaugeInspectionEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductGaugeInspectionEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Update, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Update)]
        public Task<IActionResult> Update(ProductGaugeInspectionEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductGaugeInspectionEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductGaugeInspectionEventCommand(new ProductGaugeInspectionEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}