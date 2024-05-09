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
                (_sender.Send(new GetProductGaugeInspectionEventByGuidQuery(new ProductGaugeInspectionEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductGaugeInspectionEventByIdQuery(new ProductGaugeInspectionEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductGaugeInspectionEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductGaugeInspectionEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductGaugeInspectionEventQuery(request), cancellationToken)) .ToActionResult404();

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