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
    public class AssignmentMap : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.ModifiedDate).IsRequired(true);
            builder.Property(a => a.IsActive).IsRequired(true);
            builder.Property(a => a.IsDeleted).IsRequired(true);
            builder.ToTable("Assignments");
            builder.HasOne<User>(u => u.User).WithMany(c => c.Assignments).HasForeignKey(a => a.UserId);
        }
    }
}
