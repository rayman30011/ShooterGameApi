using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataAccess.Entities
{
    public class Entity<TKey>
    {
        public TKey Id { get; set; }
    }

    public class Entity : Entity<Guid>
    {
    }
}
