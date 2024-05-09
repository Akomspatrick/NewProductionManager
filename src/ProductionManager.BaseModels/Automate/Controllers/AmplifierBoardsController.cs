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
    public  class AmplifierBoardsController  : TheBaseController<AmplifierBoardsController>
    {

        public AmplifierBoardsController(ILogger<AmplifierBoardsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<AmplifierBoardResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.AmplifierBoard.Get, Name = ProductionManagerAPIEndPoints.AmplifierBoard.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllAmplifierBoardQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(AmplifierBoardResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.AmplifierBoard.GetById, Name = ProductionManagerAPIEndPoints.AmplifierBoard.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetAmplifierBoardByGuidQuery(new AmplifierBoardGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetAmplifierBoardByIdQuery(new AmplifierBoardGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(AmplifierBoardResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.AmplifierBoard.GetByJSONBody, Name = ProductionManagerAPIEndPoints.AmplifierBoard.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] AmplifierBoardGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetAmplifierBoardQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.AmplifierBoard.Create, Name = ProductionManagerAPIEndPoints.AmplifierBoard.Create)]
        public Task<IActionResult> Create(AmplifierBoardCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateAmplifierBoardCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.AmplifierBoard.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.AmplifierBoard.Update, Name = ProductionManagerAPIEndPoints.AmplifierBoard.Update)]
        public Task<IActionResult> Update(AmplifierBoardUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateAmplifierBoardCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.AmplifierBoard.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.AmplifierBoard.Delete, Name = ProductionManagerAPIEndPoints.AmplifierBoard.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteAmplifierBoardCommand(new AmplifierBoardDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}