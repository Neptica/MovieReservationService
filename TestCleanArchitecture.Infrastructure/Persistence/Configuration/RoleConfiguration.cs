using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities;

namespace TestCleanArchitecture.Infrastructure.Persistence.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasIndex(x => x.Id, "PK_RoleId");
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.PermissionLevel).IsRequired();
        }
    }
}
