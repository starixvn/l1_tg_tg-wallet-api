using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using TGWallet.API.Features.Health.Models;

namespace TGWallet.API.Features.Health
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiVersion("1.0")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(new HealthCheckResponse 
            { 
                Status = "healthy", 
                Timestamp = DateTime.UtcNow 
            });
        }
    }
} 