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
    public  class ProductCertificatesController  : TheBaseController<ProductCertificatesController>
    {

        public ProductCertificatesController(ILogger<ProductCertificatesController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductCertificateResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificate.Get, Name = ProductionManagerAPIEndPoints.ProductCertificate.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductCertificateQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductCertificateResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificate.GetById, Name = ProductionManagerAPIEndPoints.ProductCertificate.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductCertificateByGuidQuery(new ProductCertificateGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductCertificateByIdQuery(new ProductCertificateGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductCertificateResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificate.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductCertificate.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductCertificateGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductCertificateQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductCertificate.Create, Name = ProductionManagerAPIEndPoints.ProductCertificate.Create)]
        public Task<IActionResult> Create(ProductCertificateCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductCertificateCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCertificate.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductCertificate.Update, Name = ProductionManagerAPIEndPoints.ProductCertificate.Update)]
        public Task<IActionResult> Update(ProductCertificateUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductCertificateCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductCertificate.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductCertificate.Delete, Name = ProductionManagerAPIEndPoints.ProductCertificate.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductCertificateCommand(new ProductCertificateDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}