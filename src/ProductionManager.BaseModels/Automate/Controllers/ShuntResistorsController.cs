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
    public  class ShuntResistorsController  : TheBaseController<ShuntResistorsController>
    {

        public ShuntResistorsController(ILogger<ShuntResistorsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ShuntResistorResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ShuntResistor.Get, Name = ProductionManagerAPIEndPoints.ShuntResistor.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllShuntResistorQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ShuntResistorResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ShuntResistor.GetById, Name = ProductionManagerAPIEndPoints.ShuntResistor.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetShuntResistorByGuidQuery(new ShuntResistorGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetShuntResistorByIdQuery(new ShuntResistorGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.ShuntResistor.GetByJSONBody, Name = ProductionManagerAPIEndPoints.ShuntResistor.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ShuntResistorGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetShuntResistorQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.ShuntResistor.Create, Name = ProductionManagerAPIEndPoints.ShuntResistor.Create)]
        public Task<IActionResult> Create(ShuntResistorCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateShuntResistorCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.ShuntResistor.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.ShuntResistor.Update, Name = ProductionManagerAPIEndPoints.ShuntResistor.Update)]
        public Task<IActionResult> Update(ShuntResistorUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateShuntResistorCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.ShuntResistor.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.ShuntResistor.Delete, Name = ProductionManagerAPIEndPoints.ShuntResistor.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteShuntResistorCommand(new ShuntResistorDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}