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
    public  class ProductCertificateTypesController  : TheBaseController<ProductCertificateTypesController>
    {

        public ProductCertificateTypesController(ILogger<ProductCertificateTypesController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductCertificateTypeResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificateType.Get, Name = ProductionManagerAPIEndPoints.ProductCertificateType.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductCertificateTypeQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductCertificateTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificateType.GetById, Name = ProductionManagerAPIEndPoints.ProductCertificateType.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductCertificateTypeByGuidQuery(new ProductCertificateTypeGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductCertificateTypeByIdQuery(new ProductCertificateTypeGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificateType.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductCertificateType.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductCertificateTypeGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductCertificateTypeQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductCertificateType.Create, Name = ProductionManagerAPIEndPoints.ProductCertificateType.Create)]
        public Task<IActionResult> Create(ProductCertificateTypeCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductCertificateTypeCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCertificateType.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductCertificateType.Update, Name = ProductionManagerAPIEndPoints.ProductCertificateType.Update)]
        public Task<IActionResult> Update(ProductCertificateTypeUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductCertificateTypeCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCertificateType.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductCertificateType.Delete, Name = ProductionManagerAPIEndPoints.ProductCertificateType.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductCertificateTypeCommand(new ProductCertificateTypeDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}