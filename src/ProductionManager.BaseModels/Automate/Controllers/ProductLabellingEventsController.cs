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
    public  class ProductLabellingEventsController  : TheBaseController<ProductLabellingEventsController>
    {

        public ProductLabellingEventsController(ILogger<ProductLabellingEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductLabellingEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Get, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductLabellingEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductLabellingEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductLabellingEventByGuidQuery(new ProductLabellingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductLabellingEventByIdQuery(new ProductLabellingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductLabellingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductLabellingEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Create, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Create)]
        public Task<IActionResult> Create(ProductLabellingEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductLabellingEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductLabellingEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Update, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Update)]
        public Task<IActionResult> Update(ProductLabellingEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductLabellingEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductLabellingEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductLabellingEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductLabellingEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductLabellingEventCommand(new ProductLabellingEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}