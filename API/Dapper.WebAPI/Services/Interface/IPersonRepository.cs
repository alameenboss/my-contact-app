using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services.Interface
{
    public interface IPersonRepository
    {
        Task<Person> GetById(int id);
        Task AddPerson(Person entity);
        Task UpdatePerson(Person entity, int id);
        Task DeletePerson(int id);
        Task<IEnumerable<Person>> GetPersons();
    }
}
