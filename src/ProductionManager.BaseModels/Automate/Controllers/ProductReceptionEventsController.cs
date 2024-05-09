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
    public  class ProductReceptionEventsController  : TheBaseController<ProductReceptionEventsController>
    {

        public ProductReceptionEventsController(ILogger<ProductReceptionEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductReceptionEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.Get, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductReceptionEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductReceptionEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductReceptionEventByGuidQuery(new ProductReceptionEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductReceptionEventByIdQuery(new ProductReceptionEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductReceptionEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductReceptionEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.Create, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.Create)]
        public Task<IActionResult> Create(ProductReceptionEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductReceptionEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductReceptionEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.Update, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.Update)]
        public Task<IActionResult> Update(ProductReceptionEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductReceptionEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductReceptionEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductReceptionEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductReceptionEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductReceptionEventCommand(new ProductReceptionEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}