namespace Game.DataAccess.Entities
{
    public class ItemEntity : Entity<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
    }
}
