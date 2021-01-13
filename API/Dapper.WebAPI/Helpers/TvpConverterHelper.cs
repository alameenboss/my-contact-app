using Dapper.WebAPI.Models;
using System.Collections.Generic;
using System.Data;

namespace Dapper.WebAPI.Helpers
{
    public class TvpConverterHelper : ITvpConverterHelper
    {
        public SqlMapper.ICustomQueryParameter AddressTVP(List<Address> model)
        {
            var dt = new DataTable();
            dt.Columns.Add("Line1", typeof(string));
            dt.Columns.Add("Line2", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("PinCode", typeof(string));
            if (model != null && model?.Count > 0)
            {
                model.ForEach(address =>
                {
                    dt.Rows.Add(address.Line1, address.Line2, address.City, address.State, address.PinCode);
                });
            }
            return dt.AsTableValuedParameter("dbo.UT_Address");
        }

        public SqlMapper.ICustomQueryParameter EmailTVP(List<EmailModel> model)
        {
            var dt = new DataTable();
            dt.Columns.Add("Email", typeof(string));
            if (model != null && model?.Count > 0)
            {
                model.ForEach(e =>
                {
                    dt.Rows.Add(e.Email);
                });
            }
            return dt.AsTableValuedParameter("dbo.UT_Email");
        }

        public SqlMapper.ICustomQueryParameter PhoneTVP(List<Phone> model)
        {
            var dt = new DataTable();
            dt.Columns.Add("Number", typeof(string));
            dt.Columns.Add("IsPrimary", typeof(bool));
            if (model != null && model?.Count > 0)
            {
                model.ForEach(p =>
                {
                    dt.Rows.Add(p.Number, p.IsPrimary);
                });
            }
            return dt.AsTableValuedParameter("dbo.UT_Phone");
        }
    }
}
