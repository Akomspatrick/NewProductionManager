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
    public  class ProductInitialUnitsController  : TheBaseController<ProductInitialUnitsController>
    {

        public ProductInitialUnitsController(ILogger<ProductInitialUnitsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductInitialUnitResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialUnit.Get, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductInitialUnitQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductInitialUnitResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialUnit.GetById, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductInitialUnitByGuidQuery(new ProductInitialUnitGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductInitialUnitByIdQuery(new ProductInitialUnitGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductInitialUnit.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductInitialUnitGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductInitialUnitQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductInitialUnit.Create, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.Create)]
        public Task<IActionResult> Create(ProductInitialUnitCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductInitialUnitCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInitialUnit.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductInitialUnit.Update, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.Update)]
        public Task<IActionResult> Update(ProductInitialUnitUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductInitialUnitCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductInitialUnit.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductInitialUnit.Delete, Name = ProductionManagerAPIEndPoints.ProductInitialUnit.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductInitialUnitCommand(new ProductInitialUnitDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}