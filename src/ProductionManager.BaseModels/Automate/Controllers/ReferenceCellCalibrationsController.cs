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
    public  class ReferenceCellCalibrationsController  : TheBaseController<ReferenceCellCalibrationsController>
    {

        public ReferenceCellCalibrationsController(ILogger<ReferenceCellCalibrationsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ReferenceCellCalibrationResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.Get, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllReferenceCellCalibrationQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ReferenceCellCalibrationResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.GetById, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetReferenceCellCalibrationByGuidQuery(new ReferenceCellCalibrationGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetReferenceCellCalibrationByIdQuery(new ReferenceCellCalibrationGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ReferenceCellCalibrationGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetReferenceCellCalibrationQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.Create, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.Create)]
        public Task<IActionResult> Create(ReferenceCellCalibrationCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateReferenceCellCalibrationCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ReferenceCellCalibration.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.Update, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.Update)]
        public Task<IActionResult> Update(ReferenceCellCalibrationUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateReferenceCellCalibrationCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ReferenceCellCalibration.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ReferenceCellCalibration.Delete, Name = ProductionManagerAPIEndPoints.ReferenceCellCalibration.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteReferenceCellCalibrationCommand(new ReferenceCellCalibrationDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}