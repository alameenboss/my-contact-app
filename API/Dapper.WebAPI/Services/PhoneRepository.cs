using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services
{
    public class PhoneRepository : BaseRepository, IPhoneRepository
    {

        public PhoneRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<Phone>> GetPhoneByPersonId(int personId)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Phone>(StoredProcedureConstants.GetPhoneByPersonId, 
                    new {PersonId = personId},
                    commandType: CommandType.StoredProcedure);
                return query;
            });
        }
        public async Task UpdatePhone(Phone entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.UpdatePhoneById,
                    new
                    {
                        Number = entity.Number,
                        IsPrimary = entity.IsPrimary,
                        PersonId = entity.PersonId,
                        Id = id,
                        UpdateBy = entity.UpdatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task DeletePhone(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.DeletePhoneById, new { PhoneId = id },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task AddPhoneByPersonId(Phone entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.AddPhoneByPersonId,
                    new
                    {
                        Number = entity.Number,
                        IsPrimary = entity.IsPrimary,
                        PersonId = entity.PersonId,
                        CreatedBy = entity.CreatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }

    }
}
