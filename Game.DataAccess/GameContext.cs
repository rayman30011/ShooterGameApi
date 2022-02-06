using Game.DataAccess.Config;
using Game.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataAccess
{
    public class GameContext : DbContext
    {
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<ItemInstanceEntity> ItemInstances { get; set; }
        public DbSet<StorageEntity> StorageInstances { get; set; }

        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfig());
            modelBuilder.ApplyConfiguration(new ItemInstanceConfig());
            modelBuilder.ApplyConfiguration(new StorageConfig());
        }
    }
}
