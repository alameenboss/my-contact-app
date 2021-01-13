using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {

        public AddressRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<Address>> GetAddressByPersonId(int personId)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Address>(StoredProcedureConstants.GetAddressByPersonId, 
                    new {PersonId = personId},
                    commandType: CommandType.StoredProcedure);
                return query;
            });
        }
        public async Task UpdateAddress(Address entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.UpdateAddressById,
                    new
                    {
                        Line1 = entity.Line1,
                        Line2 = entity.Line2,
                        City = entity.City,
                        State = entity.State,
                        PinCode = entity.PinCode,
                        PersonId = entity.PersonId,
                        Id = id,
                        UpdateBy = entity.UpdatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task DeleteAddress(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.DeleteAddressById, new { AddressId = id },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task AddAddressByPersonId(Address entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.AddAddressByPersonId,
                    new
                    {
                        Line1 = entity.Line1,
                        Line2 = entity.Line2,
                        City = entity.City,
                        State = entity.State,
                        PinCode = entity.PinCode,
                        PersonId = entity.PersonId,
                        CreatedBy = entity.CreatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }

    }
}
