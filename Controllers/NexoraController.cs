using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexora.Api.Services;

namespace Nexora.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NexoraController : ControllerBase
    {
        [HttpGet]
        public string GetNexoraStatus()
        {
            return "Nexora API is running.";
        }

    }
}
