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
    public  class ProductResistorInstallationEventsController  : TheBaseController<ProductResistorInstallationEventsController>
    {

        public ProductResistorInstallationEventsController(ILogger<ProductResistorInstallationEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductResistorInstallationEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Get, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductResistorInstallationEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductResistorInstallationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductResistorInstallationEventByGuidQuery(new ProductResistorInstallationEventGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductResistorInstallationEventByIdQuery(new ProductResistorInstallationEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductResistorInstallationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductResistorInstallationEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductResistorInstallationEventQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Create, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Create)]
        public Task<IActionResult> Create(ProductResistorInstallationEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductResistorInstallationEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Update, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Update)]
        public Task<IActionResult> Update(ProductResistorInstallationEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductResistorInstallationEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductResistorInstallationEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductResistorInstallationEventCommand(new ProductResistorInstallationEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}