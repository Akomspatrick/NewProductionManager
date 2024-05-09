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
                (_sender.Send(new GetTrimmingResistorByGuidQuery(new TrimmingResistorGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetTrimmingResistorByIdQuery(new TrimmingResistorGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(TrimmingResistorResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.TrimmingResistor.GetByJSONBody, Name = ProductionManagerAPIEndPoints.TrimmingResistor.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] TrimmingResistorGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetTrimmingResistorQuery(request), cancellationToken)) .ToEitherActionResult();

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