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
    public class ConnectionConfiguration : IEntityTypeConfiguration<Connection>
    {
        public void Configure(EntityTypeBuilder<Connection> builder)
        {
            builder.HasIndex(x => x.Id, "PK_ConnectionId");
            builder.HasIndex(x => x.InitFriendId, "FK.Users_DBO.Connections_InitFriendId");
            builder.HasIndex(x => x.RecFriendId, "FK.Users_DBO.Connections_RecFriendId");
            builder.Property(x => x.SendDate).IsRequired();
            builder.Property(x => x.AcceptedDate);
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
