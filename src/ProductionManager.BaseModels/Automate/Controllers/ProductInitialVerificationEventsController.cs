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
    public  class ProductInitialVerificationEventsController  : TheBaseController<ProductInitialVerificationEventsController>
    {

        public ProductInitialVerificationEventsController(ILogger<ProductInitialVerificationEventsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductInitialVerificationEventResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Get, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductInitialVerificationEventQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductInitialVerificationEventResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.GetById, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductInitialVerificationEventByGuidQuery(new ProductInitialVerificationEventGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductInitialVerificationEventByIdQuery(new ProductInitialVerificationEventGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductInitialVerificationEventGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductInitialVerificationEventQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Create, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Create)]
        public Task<IActionResult> Create(ProductInitialVerificationEventCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductInitialVerificationEventCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Update, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Update)]
        public Task<IActionResult> Update(ProductInitialVerificationEventUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductInitialVerificationEventCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Delete, Name = ProductionManagerAPIEndPoints.ProductInitialVerificationEvent.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductInitialVerificationEventCommand(new ProductInitialVerificationEventDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}