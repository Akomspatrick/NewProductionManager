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
                (_sender.Send(new GetProductCertificateByGuidQuery(new ProductCertificateGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductCertificateByIdQuery(new ProductCertificateGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductCertificate.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductCertificate.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductCertificateGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductCertificateQuery(request), cancellationToken)) .ToActionResult404();

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