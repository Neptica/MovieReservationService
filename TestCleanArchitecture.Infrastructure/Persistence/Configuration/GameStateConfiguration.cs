using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities;

namespace MovieReservationService.Infrastructure.Persistence.Configuration
{
    public class GameStateConfiguration : IEntityTypeConfiguration<GameState>
    {
        public void Configure(EntityTypeBuilder<GameState> builder)
        {
            builder.HasIndex(x => x.Id, "PK_GameStateId");
            builder.Property(x => x.SquareOne);
            builder.Property(x => x.SquareTwo);
            builder.Property(x => x.SquareThree);
            builder.Property(x => x.SquareFour);
            builder.Property(x => x.SquareFive);
            builder.Property(x => x.SquareSix);
            builder.Property(x => x.SquareSeven);
            builder.Property(x => x.SquareEight);
            builder.Property(x => x.SquareNine);
        }
    }
}
