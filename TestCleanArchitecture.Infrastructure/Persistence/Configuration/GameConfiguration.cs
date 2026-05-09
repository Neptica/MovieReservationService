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
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasIndex(x => x.Id, "PK_GameId");
            builder.HasIndex(x => x.PlayerOneId, "FK.Users_DBO.Games_PlayerOneId");
            builder.HasIndex(x => x.PlayerTwoId, "FK.Users_DBO.Games_PlayerTwoId");
            builder.Property(x => x.Winner);
            builder.Property(x => x.Tie);
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
