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
    public  class ProductsController  : TheBaseController<ProductsController>
    {

        public ProductsController(ILogger<ProductsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Product.Get, Name = ProductionManagerAPIEndPoints.Product.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Product.GetById, Name = ProductionManagerAPIEndPoints.Product.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductByGuidQuery(new ProductGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductByIdQuery(new ProductGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Product.GetByJSONBody, Name = ProductionManagerAPIEndPoints.Product.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.Product.Create, Name = ProductionManagerAPIEndPoints.Product.Create)]
        public Task<IActionResult> Create(ProductCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.Product.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.Product.Update, Name = ProductionManagerAPIEndPoints.Product.Update)]
        public Task<IActionResult> Update(ProductUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.Product.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.Product.Delete, Name = ProductionManagerAPIEndPoints.Product.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductCommand(new ProductDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}