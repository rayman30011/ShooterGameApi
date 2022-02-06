using System.Text.Json.Nodes;

namespace Game.DataAccess.Entities
{
    public class ItemInstanceEntity : Entity
    {
        public string ItemId { get; set; }
        public ItemEntity Item { get; set; }
        public JsonObject Data { get; set; }
    }
}
