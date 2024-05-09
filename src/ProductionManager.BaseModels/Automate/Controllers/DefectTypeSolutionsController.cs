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
    public  class DefectTypeSolutionsController  : TheBaseController<DefectTypeSolutionsController>
    {

        public DefectTypeSolutionsController(ILogger<DefectTypeSolutionsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<DefectTypeSolutionResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectTypeSolution.Get, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllDefectTypeSolutionQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(DefectTypeSolutionResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectTypeSolution.GetById, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetDefectTypeSolutionByGuidQuery(new DefectTypeSolutionGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetDefectTypeSolutionByIdQuery(new DefectTypeSolutionGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(DefectTypeSolutionResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectTypeSolution.GetByJSONBody, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] DefectTypeSolutionGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetDefectTypeSolutionQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.DefectTypeSolution.Create, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.Create)]
        public Task<IActionResult> Create(DefectTypeSolutionCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateDefectTypeSolutionCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.DefectTypeSolution.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.DefectTypeSolution.Update, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.Update)]
        public Task<IActionResult> Update(DefectTypeSolutionUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateDefectTypeSolutionCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.DefectTypeSolution.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.DefectTypeSolution.Delete, Name = ProductionManagerAPIEndPoints.DefectTypeSolution.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteDefectTypeSolutionCommand(new DefectTypeSolutionDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}