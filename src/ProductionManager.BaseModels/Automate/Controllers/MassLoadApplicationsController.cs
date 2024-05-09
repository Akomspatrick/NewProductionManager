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
    public  class MassLoadApplicationsController  : TheBaseController<MassLoadApplicationsController>
    {

        public MassLoadApplicationsController(ILogger<MassLoadApplicationsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<MassLoadApplicationResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassLoadApplication.Get, Name = ProductionManagerAPIEndPoints.MassLoadApplication.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllMassLoadApplicationQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(MassLoadApplicationResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassLoadApplication.GetById, Name = ProductionManagerAPIEndPoints.MassLoadApplication.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetMassLoadApplicationByGuidQuery(new MassLoadApplicationGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetMassLoadApplicationByIdQuery(new MassLoadApplicationGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassLoadApplication.GetByJSONBody, Name = ProductionManagerAPIEndPoints.MassLoadApplication.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] MassLoadApplicationGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetMassLoadApplicationQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.MassLoadApplication.Create, Name = ProductionManagerAPIEndPoints.MassLoadApplication.Create)]
        public Task<IActionResult> Create(MassLoadApplicationCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateMassLoadApplicationCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.MassLoadApplication.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.MassLoadApplication.Update, Name = ProductionManagerAPIEndPoints.MassLoadApplication.Update)]
        public Task<IActionResult> Update(MassLoadApplicationUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateMassLoadApplicationCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.MassLoadApplication.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.MassLoadApplication.Delete, Name = ProductionManagerAPIEndPoints.MassLoadApplication.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteMassLoadApplicationCommand(new MassLoadApplicationDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}