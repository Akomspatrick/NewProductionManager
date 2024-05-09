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
    public  class ProductAdditionalInfosController  : TheBaseController<ProductAdditionalInfosController>
    {

        public ProductAdditionalInfosController(ILogger<ProductAdditionalInfosController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductAdditionalInfoResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.Get, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductAdditionalInfoQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductAdditionalInfoResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetById, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductAdditionalInfoByGuidQuery(new ProductAdditionalInfoGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductAdditionalInfoByIdQuery(new ProductAdditionalInfoGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductAdditionalInfoResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductAdditionalInfoGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductAdditionalInfoQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.Create, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.Create)]
        public Task<IActionResult> Create(ProductAdditionalInfoCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductAdditionalInfoCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductAdditionalInfo.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.Update, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.Update)]
        public Task<IActionResult> Update(ProductAdditionalInfoUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductAdditionalInfoCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductAdditionalInfo.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.Delete, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductAdditionalInfoCommand(new ProductAdditionalInfoDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}