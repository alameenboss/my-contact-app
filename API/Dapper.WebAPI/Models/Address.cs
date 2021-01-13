namespace Dapper.WebAPI.Models
{
    public class Address : BaseEntity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public int PersonId { get; set; }
    }
}