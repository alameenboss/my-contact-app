using Dapper.WebAPI.Models;
using System.Collections.Generic;

namespace Dapper.WebAPI.Helpers
{
    public interface ITvpConverterHelper
    {
        SqlMapper.ICustomQueryParameter AddressTVP(List<Address> model);
        SqlMapper.ICustomQueryParameter EmailTVP(List<EmailModel> model);
        SqlMapper.ICustomQueryParameter PhoneTVP(List<Phone> model);
    }
}
