namespace Dapper.WebAPI.Models
{
    public class Phone : BaseEntity
    {
        public string Number { get; set; }
        public bool IsPrimary { get; set; }
        public int PersonId { get; set; }
    }
}