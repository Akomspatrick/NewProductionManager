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
    public  class ProductFinalUnitsController  : TheBaseController<ProductFinalUnitsController>
    {

        public ProductFinalUnitsController(ILogger<ProductFinalUnitsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductFinalUnitResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalUnit.Get, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductFinalUnitQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductFinalUnitResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalUnit.GetById, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductFinalUnitByGuidQuery(new ProductFinalUnitGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProductFinalUnitByIdQuery(new ProductFinalUnitGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ProductFinalUnitResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductFinalUnit.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductFinalUnitGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductFinalUnitQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductFinalUnit.Create, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.Create)]
        public Task<IActionResult> Create(ProductFinalUnitCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductFinalUnitCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinalUnit.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductFinalUnit.Update, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.Update)]
        public Task<IActionResult> Update(ProductFinalUnitUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductFinalUnitCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductFinalUnit.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductFinalUnit.Delete, Name = ProductionManagerAPIEndPoints.ProductFinalUnit.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductFinalUnitCommand(new ProductFinalUnitDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}