using Dapper.WebAPI.Helpers;
using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        private readonly ITvpConverterHelper _tvpHelper; 

        public PersonRepository(IConfiguration configuration, ITvpConverterHelper tvpHelper) : base(configuration)
        {
            _tvpHelper = tvpHelper;
        }
        public async Task<IEnumerable<Person>> GetPersons()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Person>(StoredProcedureConstants.GetPersons,commandType: CommandType.StoredProcedure);
                return query;
            });

        }

        public async Task<Person> GetById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<Person>(StoredProcedureConstants.GetPersonById, 
                    new { PersonId = id }, 
                    commandType: CommandType.StoredProcedure);
                return query;
            });

        }

        public async Task AddPerson(Person entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.AddPerson,
                    new { 
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Address = _tvpHelper.AddressTVP(entity.Addresses),
                        Email = _tvpHelper.EmailTVP(entity.Emails),
                        Phone = _tvpHelper.PhoneTVP(entity.Phones)
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }

        public async Task UpdatePerson(Person entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.UpdatePerson,
                    new {
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Id = id 
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }

        public async Task DeletePerson(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.DeletePersonById, new { PersonId = id },
                    commandType: CommandType.StoredProcedure);
            });

        }

    }
}
