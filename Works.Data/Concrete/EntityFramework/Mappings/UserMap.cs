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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.UserName).IsRequired(true);
            builder.Property(r => r.ModifiedDate).IsRequired(true);
            builder.Property(r => r.IsActive).IsRequired(true);
            builder.Property(r => r.IsDeleted).IsRequired(true);
            builder.Property(r => r.UserName).HasMaxLength(40);
            builder.HasOne<Role>(a => a.Role).WithMany(c => c.Users).HasForeignKey(a => a.RoleId);
            builder.ToTable("Users");
        }
    }
}
