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
    public  class MassfussionFunctionsController  : TheBaseController<MassfussionFunctionsController>
    {

        public MassfussionFunctionsController(ILogger<MassfussionFunctionsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<MassfussionFunctionResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassfussionFunction.Get, Name = ProductionManagerAPIEndPoints.MassfussionFunction.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllMassfussionFunctionQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(MassfussionFunctionResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassfussionFunction.GetById, Name = ProductionManagerAPIEndPoints.MassfussionFunction.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetMassfussionFunctionByGuidQuery(new MassfussionFunctionGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetMassfussionFunctionByIdQuery(new MassfussionFunctionGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.MassfussionFunction.GetByJSONBody, Name = ProductionManagerAPIEndPoints.MassfussionFunction.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] MassfussionFunctionGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetMassfussionFunctionQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.MassfussionFunction.Create, Name = ProductionManagerAPIEndPoints.MassfussionFunction.Create)]
        public Task<IActionResult> Create(MassfussionFunctionCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateMassfussionFunctionCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.MassfussionFunction.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.MassfussionFunction.Update, Name = ProductionManagerAPIEndPoints.MassfussionFunction.Update)]
        public Task<IActionResult> Update(MassfussionFunctionUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateMassfussionFunctionCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.MassfussionFunction.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.MassfussionFunction.Delete, Name = ProductionManagerAPIEndPoints.MassfussionFunction.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteMassfussionFunctionCommand(new MassfussionFunctionDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}