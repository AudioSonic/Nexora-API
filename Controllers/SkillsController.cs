using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexora.Api.Models;
using Nexora.Api.Services;

namespace Nexora.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly SkillsService _service;
        public SkillsController(SkillsService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Skill> GetSkills()
        {
            return _service.GetSkillList();
        }

        [HttpGet("{id}")]
        public ActionResult<Skill> GetSkill(int id)
        {
            Skill skill = _service.GetSkill(id);

            if(skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
        }

        [HttpPost]
        public ActionResult<Skill> CreateSkill(Skill skill)
        {
            Skill newSkill = _service.AddNewSkill(skill);

            return Created("", newSkill);
        }
    }
}
