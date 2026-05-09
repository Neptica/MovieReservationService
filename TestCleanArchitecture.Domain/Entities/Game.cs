using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class Game : Entity
    {
        public int PlayerOneId { get; set; }
        public int PlayerTwoId { get; set; }
        public bool Winner {  get; set; }
        public bool Tie {  get; set; }
        public bool IsActive {  get; set; }
    }
}
