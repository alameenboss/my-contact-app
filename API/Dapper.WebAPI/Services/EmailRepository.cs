using Dapper.WebAPI.Models;
using Dapper.WebAPI.Services.Interface;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services
{
    public class EmailRepository : BaseRepository, IEmailRepository
    {

        public EmailRepository(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task<IEnumerable<EmailModel>> GetEmailByPersonId(int personId)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<EmailModel>(StoredProcedureConstants.GetEmailByPersonId, 
                    new {PersonId = personId},
                    commandType: CommandType.StoredProcedure);
                return query;
            });
        }
        public async Task UpdateEmail(EmailModel entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.UpdateEmailById,
                    new
                    {
                        Email = entity.Email,
                        PersonId = entity.PersonId,
                        Id = id,
                        UpdateBy = entity.UpdatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task DeleteEmail(int id)
        {

            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.DeleteEmailById, new { EmailId = id },
                    commandType: CommandType.StoredProcedure);
            });

        }
        public async Task AddEmailByPersonId(EmailModel entity)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(StoredProcedureConstants.AddEmailByPersonId,
                    new
                    {
                        Email = entity.Email,
                        PersonId = entity.PersonId,
                        CreatedBy = entity.CreatedBy
                    },
                    commandType: CommandType.StoredProcedure);
            });

        }

    }
}
