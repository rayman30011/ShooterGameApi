using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataAccess.Entities.Storage
{
    public class StorageItem
    {
        public Guid InstId { get; set; }
        public Point Pos { get; set; }
    }
}
