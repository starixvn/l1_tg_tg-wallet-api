using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using TGWallet.API.Features.Wallets.Commands;
using Sentry;
using MediatR;
using System.Numerics;
using TGWallet.API.Features.Wallets.Models.Balance;
using TGWallet.API.Features.Wallets.Models.AddBalance;

namespace TGWallet.API.Features.Wallets
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiVersion("1.0")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _playerService;
        private readonly IHub _sentryHub;
        private readonly IMediator _mediator;

        public WalletController(IWalletService playerService, IHub sentryHub, IMediator mediator)
        {
            _playerService = playerService;
            _sentryHub = sentryHub;
            _mediator = mediator;
        }

        [HttpPost("balance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetBalance([FromBody] PlayerBalanceRequest request)
        {
            try
            {
                var balance = await _playerService.GetPlayerBalanceAsync(
                    request.PlayerId);

                return Ok(new
                { 
                    balance,
                    status = "success"
                });
            }
            catch (Exception ex)
            {
                _sentryHub.CaptureException(ex);
                throw;
            }
        }
        
        [HttpPost("deductBalance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DeductBalanceRequest>> PlaceBet([FromBody] DeductBalanceRequest request)
        {
            try
            {
                var result = await _mediator.Send(new DeductBalanceCommand(request));
                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                _sentryHub.CaptureException(ex);
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("addBalance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AddBalanceResponse>> EndRound([FromBody] AddBalanceRequest request)
        {
            try
            {
                var result = await _mediator.Send(new AddBallanceCommand(request));
                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
             
                return BadRequest(new { message = ex.Message });
            }
        }
    }
} 