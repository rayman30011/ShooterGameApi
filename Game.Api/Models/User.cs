namespace Game.Api.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid MainStorageId { get; set; }
    }
}
