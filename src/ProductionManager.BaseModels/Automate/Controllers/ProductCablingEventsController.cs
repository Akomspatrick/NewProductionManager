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
                (_sender.Send(new GetProductCablingEventByGuidQuery(new ProductCablingEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductCablingEventByIdQuery(new ProductCablingEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCablingEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductCablingEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductCablingEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductCablingEventQuery(request), cancellationToken)) .ToActionResult404();

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