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
    public  class TestsController  : TheBaseController<TestsController>
    {

        public TestsController(ILogger<TestsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<TestResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Test.Get, Name = ProductionManagerAPIEndPoints.Test.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllTestQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(TestResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Test.GetById, Name = ProductionManagerAPIEndPoints.Test.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetTestByGuidQuery(new TestGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetTestByIdQuery(new TestGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.Test.GetByJSONBody, Name = ProductionManagerAPIEndPoints.Test.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] TestGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetTestQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.Test.Create, Name = ProductionManagerAPIEndPoints.Test.Create)]
        public Task<IActionResult> Create(TestCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateTestCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.Test.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.Test.Update, Name = ProductionManagerAPIEndPoints.Test.Update)]
        public Task<IActionResult> Update(TestUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateTestCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.Test.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.Test.Delete, Name = ProductionManagerAPIEndPoints.Test.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteTestCommand(new TestDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}