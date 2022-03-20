using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Entities.Concrete;

namespace Works.Data.Concrete.EntityFramework.Mappings
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Id).ValueGeneratedOnAdd();
            builder.Property(w => w.WorkName).IsRequired(true);
            builder.Property(w => w.ModifiedDate).IsRequired(true);
            builder.Property(w => w.IsActive).IsRequired(true);
            builder.Property(w => w.IsDeleted).IsRequired(true);
            builder.Property(w => w.WorkName).HasMaxLength(80);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Works).HasForeignKey(a => a.CategoryId);
            builder.HasOne<Assignment>(a => a.Assignment).WithMany(c => c.Works).HasForeignKey(a => a.AssignmentId);
            builder.ToTable("Works");
        }
    }
}

