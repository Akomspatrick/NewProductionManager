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
    public  class ProductStagesController  : TheBaseController<ProductStagesController>
    {

        public ProductStagesController(ILogger<ProductStagesController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ProductStageResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductStage.Get, Name = ProductionManagerAPIEndPoints.ProductStage.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProductStageQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProductStageResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductStage.GetById, Name = ProductionManagerAPIEndPoints.ProductStage.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetProductStageByGuidQuery(new ProductStageGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetProductStageByIdQuery(new ProductStageGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ProductStage.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ProductStage.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProductStageGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetProductStageQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ProductStage.Create, Name = ProductionManagerAPIEndPoints.ProductStage.Create)]
        public Task<IActionResult> Create(ProductStageCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProductStageCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductStage.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ProductStage.Update, Name = ProductionManagerAPIEndPoints.ProductStage.Update)]
        public Task<IActionResult> Update(ProductStageUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProductStageCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ProductStage.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ProductStage.Delete, Name = ProductionManagerAPIEndPoints.ProductStage.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteProductStageCommand(new ProductStageDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}