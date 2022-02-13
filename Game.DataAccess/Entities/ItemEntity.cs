namespace Game.DataAccess.Entities
{
    public class ItemEntity : Entity<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
        public int Widht { get; set; }
        public int Height { get; set; }
    }
}
