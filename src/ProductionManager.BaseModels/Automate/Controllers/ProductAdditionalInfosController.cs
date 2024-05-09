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
                (_sender.Send(new GetProductAdditionalInfoByGuidQuery(new ProductAdditionalInfoGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductAdditionalInfoByIdQuery(new ProductAdditionalInfoGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductAdditionalInfo.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductAdditionalInfoGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductAdditionalInfoQuery(request), cancellationToken)) .ToActionResult404();

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