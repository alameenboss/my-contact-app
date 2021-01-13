using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons()
        {
            var person = await _personRepository.GetPersons();
            return Ok(person);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetById(int id)
        {
            var person = await _personRepository.GetById(id);
            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult> AddPerson(Person entity)
        {
            await _personRepository.AddPerson(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Person>> UpdatePerson(Person entity, int id)
        {
            await _personRepository.UpdatePerson(entity, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _personRepository.DeletePerson(id);
            return Ok();
        }

    }
}
