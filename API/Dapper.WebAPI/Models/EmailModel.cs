namespace Dapper.WebAPI.Models
{
    public class EmailModel : BaseEntity
    {
        public string Email { get; set; }
        public int PersonId { get; set; }
    }
}