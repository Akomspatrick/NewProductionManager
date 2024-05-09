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
    public  class DefectTypesController  : TheBaseController<DefectTypesController>
    {

        public DefectTypesController(ILogger<DefectTypesController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<DefectTypeResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectType.Get, Name = ProductionManagerAPIEndPoints.DefectType.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllDefectTypeQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(DefectTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectType.GetById, Name = ProductionManagerAPIEndPoints.DefectType.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetDefectTypeByGuidQuery(new DefectTypeGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetDefectTypeByIdQuery(new DefectTypeGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(DefectTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.DefectType.GetByJSONBody, Name = ProductionManagerAPIEndPoints.DefectType.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] DefectTypeGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetDefectTypeQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.DefectType.Create, Name = ProductionManagerAPIEndPoints.DefectType.Create)]
        public Task<IActionResult> Create(DefectTypeCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateDefectTypeCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.DefectType.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.DefectType.Update, Name = ProductionManagerAPIEndPoints.DefectType.Update)]
        public Task<IActionResult> Update(DefectTypeUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateDefectTypeCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.DefectType.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.DefectType.Delete, Name = ProductionManagerAPIEndPoints.DefectType.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteDefectTypeCommand(new DefectTypeDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}