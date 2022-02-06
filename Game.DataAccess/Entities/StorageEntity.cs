using Game.DataAccess.Entities.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Game.DataAccess.Entities
{
    public class StorageEntity : Entity
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<StorageItem> Items { get; set; } = new List<StorageItem>();
    }
}
