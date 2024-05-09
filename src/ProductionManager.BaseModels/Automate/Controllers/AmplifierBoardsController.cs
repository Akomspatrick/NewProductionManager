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
                (_sender.Send(new GetAmplifierBoardByGuidQuery(new AmplifierBoardGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetAmplifierBoardByIdQuery(new AmplifierBoardGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.AmplifierBoard.GetByJSONBody, Name = ProductionManagerAPIEndPoints.AmplifierBoard.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] AmplifierBoardGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetAmplifierBoardQuery(request), cancellationToken)) .ToActionResult404();

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