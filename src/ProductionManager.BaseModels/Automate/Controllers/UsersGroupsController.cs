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
    public  class UsersGroupsController  : TheBaseController<UsersGroupsController>
    {

        public UsersGroupsController(ILogger<UsersGroupsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<UsersGroupResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.UsersGroup.Get, Name = ProductionManagerAPIEndPoints.UsersGroup.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllUsersGroupQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(UsersGroupResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.UsersGroup.GetById, Name = ProductionManagerAPIEndPoints.UsersGroup.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetUsersGroupByGuidQuery(new UsersGroupGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetUsersGroupByIdQuery(new UsersGroupGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.UsersGroup.GetByJSONBody, Name = ProductionManagerAPIEndPoints.UsersGroup.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] UsersGroupGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetUsersGroupQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.UsersGroup.Create, Name = ProductionManagerAPIEndPoints.UsersGroup.Create)]
        public Task<IActionResult> Create(UsersGroupCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateUsersGroupCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.UsersGroup.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.UsersGroup.Update, Name = ProductionManagerAPIEndPoints.UsersGroup.Update)]
        public Task<IActionResult> Update(UsersGroupUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateUsersGroupCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.UsersGroup.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.UsersGroup.Delete, Name = ProductionManagerAPIEndPoints.UsersGroup.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteUsersGroupCommand(new UsersGroupDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}