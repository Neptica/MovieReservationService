using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class GameState : Entity
    {
        public int SquareOne { get; set; }
        public int SquareTwo { get; set; }
        public int SquareThree { get; set; }
        public int SquareFour { get; set; }
        public int SquareFive { get; set; }
        public int SquareSix { get; set; } 
        public int SquareSeven { get; set; }
        public int SquareEight { get; set; }
        public int SquareNine { get; set; }
    }
}
