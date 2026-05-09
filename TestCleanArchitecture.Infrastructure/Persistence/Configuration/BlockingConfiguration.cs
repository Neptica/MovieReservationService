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
    internal class BlockingConfiguration : IEntityTypeConfiguration<Blocking>
    {
        public void Configure(EntityTypeBuilder<Blocking> builder)
        {
            builder.HasIndex(x => x.Id, "PK_UserId").IsUnique();
            builder.HasIndex(x => x.BlockingPlayerId, "FK.Users_Id.Blockings_BlockingPlayerId");
            builder.HasIndex(x => x.BlockedPlayerId, "FK.Users_Id.Blockings_BlockedPlayerId");
            builder.Property(x => x.BlockedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
