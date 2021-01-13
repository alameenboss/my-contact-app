using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _emailRepository;

        public EmailController(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        [HttpGet("{personId}")]
        public async Task<ActionResult<EmailModel>> GetEmailByPersonId(int personId)
        {
            var emails = await _emailRepository.GetEmailByPersonId(personId);
            return Ok(emails);
        }

        [HttpPost]
        public async Task<ActionResult> AddEmailByPersonId(EmailModel entity)
        {
            await _emailRepository.AddEmailByPersonId(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EmailModel>> Update(EmailModel entity, int id)
        {
            await _emailRepository.UpdateEmail(entity, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _emailRepository.DeleteEmail(id);
            return Ok();
        }
    }
}
