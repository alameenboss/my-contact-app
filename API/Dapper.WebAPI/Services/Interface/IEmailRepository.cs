using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.WebAPI.Services.Interface
{
    public interface IEmailRepository
    {

        Task UpdateEmail(EmailModel entity, int id);
        Task DeleteEmail(int id);
        Task AddEmailByPersonId(EmailModel entity);
        Task<IEnumerable<EmailModel>> GetEmailByPersonId(int personId);

    }
}
