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
    public  class RefreshTokensController  : TheBaseController<RefreshTokensController>
    {

        public RefreshTokensController(ILogger<RefreshTokensController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<RefreshTokenResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.RefreshToken.Get, Name = ProductionManagerAPIEndPoints.RefreshToken.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllRefreshTokenQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(RefreshTokenResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.RefreshToken.GetById, Name = ProductionManagerAPIEndPoints.RefreshToken.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetRefreshTokenByGuidQuery(new RefreshTokenGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetRefreshTokenByIdQuery(new RefreshTokenGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: ProductionManagerAPIEndPoints.RefreshToken.GetByJSONBody, Name = ProductionManagerAPIEndPoints.RefreshToken.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] RefreshTokenGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetRefreshTokenQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: ProductionManagerAPIEndPoints.RefreshToken.Create, Name = ProductionManagerAPIEndPoints.RefreshToken.Create)]
        public Task<IActionResult> Create(RefreshTokenCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateRefreshTokenCommand(request), cancellationToken)).ToActionResultCreated($"{ProductionManagerAPIEndPoints.RefreshToken.Create}", request);

        [HttpPut(template: ProductionManagerAPIEndPoints.RefreshToken.Update, Name = ProductionManagerAPIEndPoints.RefreshToken.Update)]
        public Task<IActionResult> Update(RefreshTokenUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateRefreshTokenCommand(request), cancellationToken)) .ToActionResultCreated($"{ProductionManagerAPIEndPoints.RefreshToken.Create}", request);


        [HttpDelete(template: ProductionManagerAPIEndPoints.RefreshToken.Delete, Name = ProductionManagerAPIEndPoints.RefreshToken.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteRefreshTokenCommand(new RefreshTokenDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}