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
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasIndex(x => x.Id, "PK_PermissionId");
            builder.Property(x => x.ActionName).IsRequired();
            builder.Property(x => x.SecurityLevelRequired).IsRequired();
        }
    }
}
