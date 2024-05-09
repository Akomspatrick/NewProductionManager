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
    public  class ProductPicturesController  : TheBaseController<ProductPicturesController>
    {

        public ProductPicturesController(ILogger<ProductPicturesController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductPictureResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductPicture.Get, Name = ProductionManagerAPIEndPoints.ProductPicture.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductPictureQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductPictureResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductPicture.GetById, Name = ProductionManagerAPIEndPoints.ProductPicture.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductPictureByGuidQuery(new ProductPictureGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductPictureByIdQuery(new ProductPictureGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductPictureResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductPicture.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductPicture.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductPictureGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductPictureQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductPicture.Create, Name = ProductionManagerAPIEndPoints.ProductPicture.Create)]
        public Task<IActionResult> Create(ProductPictureCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductPictureCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductPicture.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductPicture.Update, Name = ProductionManagerAPIEndPoints.ProductPicture.Update)]
        public Task<IActionResult> Update(ProductPictureUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductPictureCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductPicture.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductPicture.Delete, Name = ProductionManagerAPIEndPoints.ProductPicture.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductPictureCommand(new ProductPictureDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}