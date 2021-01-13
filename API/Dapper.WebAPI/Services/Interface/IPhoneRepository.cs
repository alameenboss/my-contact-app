using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services.Interface
{
    public interface IPhoneRepository
    {

        Task UpdatePhone(Phone entity, int id);
        Task DeletePhone(int id);
        Task AddPhoneByPersonId(Phone entity);
        Task<IEnumerable<Phone>> GetPhoneByPersonId(int personId);

    }
}
