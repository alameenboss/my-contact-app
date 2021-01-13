using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpGet("{personId}")]
        public async Task<ActionResult<Address>> GetAddressByPersonId(int personId)
        {
            var addresss = await _addressRepository.GetAddressByPersonId(personId);
            return Ok(addresss);
        }

        [HttpPost]
        public async Task<ActionResult> AddAddressByPersonId(Address entity)
        {
            await _addressRepository.AddAddressByPersonId(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Address>> Update(Address entity, int id)
        {
            await _addressRepository.UpdateAddress(entity, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _addressRepository.DeleteAddress(id);
            return Ok();
        }
    }
}
