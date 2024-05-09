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
    public  class ModelVersionsController  : TheBaseController<ModelVersionsController>
    {

        public ModelVersionsController(ILogger<ModelVersionsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ModelVersionResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ModelVersion.Get, Name = ProductionManagerAPIEndPoints.ModelVersion.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllModelVersionQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ModelVersionResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ModelVersion.GetById, Name = ProductionManagerAPIEndPoints.ModelVersion.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetModelVersionByGuidQuery(new ModelVersionGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetModelVersionByIdQuery(new ModelVersionGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ModelVersion.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ModelVersion.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ModelVersionGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetModelVersionQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ModelVersion.Create, Name = ProductionManagerAPIEndPoints.ModelVersion.Create)]
        public Task<IActionResult> Create(ModelVersionCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateModelVersionCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ModelVersion.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ModelVersion.Update, Name = ProductionManagerAPIEndPoints.ModelVersion.Update)]
        public Task<IActionResult> Update(ModelVersionUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateModelVersionCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ModelVersion.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ModelVersion.Delete, Name = ProductionManagerAPIEndPoints.ModelVersion.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteModelVersionCommand(new ModelVersionDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}