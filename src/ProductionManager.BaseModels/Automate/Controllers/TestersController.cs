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
    public  class TestersController  : TheBaseController<TestersController>
    {

        public TestersController(ILogger<TestersController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<TesterResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Tester.Get, Name = ProductionManagerAPIEndPoints.Tester.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllTesterQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(TesterResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Tester.GetById, Name = ProductionManagerAPIEndPoints.Tester.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetTesterByGuidQuery(new TesterGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetTesterByIdQuery(new TesterGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(TesterResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Tester.GetByJSONBody, Name = ProductionManagerAPIEndPoints.Tester.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] TesterGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetTesterQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: ProductionManagerAPIEndPoints.Tester.Create, Name = ProductionManagerAPIEndPoints.Tester.Create)]
        public Task<IActionResult> Create(TesterCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateTesterCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.Tester.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.Tester.Update, Name = ProductionManagerAPIEndPoints.Tester.Update)]
        public Task<IActionResult> Update(TesterUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateTesterCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.Tester.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.Tester.Delete, Name = ProductionManagerAPIEndPoints.Tester.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteTesterCommand(new TesterDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}