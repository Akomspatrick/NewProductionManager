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
    public  class TrimmingResistorsController  : TheBaseController<TrimmingResistorsController>
    {

        public TrimmingResistorsController(ILogger<TrimmingResistorsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<TrimmingResistorResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.TrimmingResistor.Get, Name = ProductionManagerAPIEndPoints.TrimmingResistor.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllTrimmingResistorQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(TrimmingResistorResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.TrimmingResistor.GetById, Name = ProductionManagerAPIEndPoints.TrimmingResistor.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetTrimmingResistorByGuidQuery(new TrimmingResistorGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetTrimmingResistorByIdQuery(new TrimmingResistorGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.TrimmingResistor.GetByJSONBody, Name = ProductionManagerAPIEndPoints.TrimmingResistor.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] TrimmingResistorGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetTrimmingResistorQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.TrimmingResistor.Create, Name = ProductionManagerAPIEndPoints.TrimmingResistor.Create)]
        public Task<IActionResult> Create(TrimmingResistorCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateTrimmingResistorCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.TrimmingResistor.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.TrimmingResistor.Update, Name = ProductionManagerAPIEndPoints.TrimmingResistor.Update)]
        public Task<IActionResult> Update(TrimmingResistorUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateTrimmingResistorCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.TrimmingResistor.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.TrimmingResistor.Delete, Name = ProductionManagerAPIEndPoints.TrimmingResistor.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteTrimmingResistorCommand(new TrimmingResistorDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}