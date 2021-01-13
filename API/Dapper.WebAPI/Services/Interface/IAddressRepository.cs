using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services.Interface
{
    public interface IAddressRepository
    {

        Task UpdateAddress(Address entity, int id);
        Task DeleteAddress(int id);
        Task AddAddressByPersonId(Address entity);
        Task<IEnumerable<Address>> GetAddressByPersonId(int personId);

    }
}
