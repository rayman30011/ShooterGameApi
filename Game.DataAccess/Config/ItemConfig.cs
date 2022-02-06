using Game.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.DataAccess.Config
{
    public class ItemConfig : IEntityTypeConfiguration<ItemEntity>
    {
        public void Configure(EntityTypeBuilder<ItemEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Schema).IsRequired(false);
        }
    }

    public class ItemInstanceConfig : IEntityTypeConfiguration<ItemInstanceEntity>
    {
        public void Configure(EntityTypeBuilder<ItemInstanceEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Item).WithMany().HasForeignKey(x => x.ItemId);
            builder.Property(x => x.Data).HasColumnType("jsonb");
        }
    }

    public class StorageConfig : IEntityTypeConfiguration<StorageEntity>
    {
        public void Configure(EntityTypeBuilder<StorageEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Items).HasColumnType("jsonb");
            builder.Property(x => x.Name).IsRequired(false);
            builder.Property(x => x.Width).IsRequired(true);
            builder.Property(x => x.Height).IsRequired(true);
        }
    }
}
