using System.Collections.Generic;

namespace Dapper.WebAPI.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            List<Address> Addresses = new List<Address>();
            List<Phone> Phones = new List<Phone>();
            List<EmailModel> Emails = new List<EmailModel>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
        public List<EmailModel> Emails { get; set; }
    }
}