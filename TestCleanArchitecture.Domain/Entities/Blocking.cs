using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class Blocking : Entity
    {
        public int BlockingPlayerId { get; set; }
        public int BlockedPlayerId { get; set; }
        public DateTime BlockedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
