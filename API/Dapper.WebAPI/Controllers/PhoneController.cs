using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneController(IPhoneRepository phoneRepository)
        {
            _phoneRepository = phoneRepository;
        }

        [HttpGet("{personId}")]
        public async Task<ActionResult<Phone>> GetPhoneByPersonId(int personId)
        {
            var phones = await _phoneRepository.GetPhoneByPersonId(personId);
            return Ok(phones);
        }

        [HttpPost]
        public async Task<ActionResult> AddPhoneByPersonId(Phone entity)
        {
            await _phoneRepository.AddPhoneByPersonId(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Phone>> Update(Phone entity, int id)
        {
            await _phoneRepository.UpdatePhone(entity, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _phoneRepository.DeletePhone(id);
            return Ok();
        }
    }
}
