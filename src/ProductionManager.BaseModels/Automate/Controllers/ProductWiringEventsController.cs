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
                (_sender.Send(new GetProductWiringEventByGuidQuery(new ProductWiringEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductWiringEventByIdQuery(new ProductWiringEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductWiringEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductWiringEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductWiringEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductWiringEventQuery(request), cancellationToken)) .ToActionResult404();

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