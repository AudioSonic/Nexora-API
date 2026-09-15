using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexora.Api.Services;

namespace Nexora.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NexoraController : ControllerBase
    {
        private readonly NexoraService _service;
        public NexoraController(NexoraService service)
        {
            _service = service;
        }

        [HttpGet]
        public string GetNexoraStatus()
        {
            return _service.GetNexoraMessage();
        }

    }
}
