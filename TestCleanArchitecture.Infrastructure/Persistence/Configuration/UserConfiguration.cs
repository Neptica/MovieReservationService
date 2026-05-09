using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities;

namespace MovieReservationService.Infrastructure.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(x => x.Id, "PK_UserId");
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.UserLogin).IsRequired();
            builder.Property(x => x.UserPassword).IsRequired();
            builder.Property(x => x.JoinedDate).IsRequired();
            builder.HasIndex(x => x.RoleId, "FK_RoleId");
        }
    }
}
