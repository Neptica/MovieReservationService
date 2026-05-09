using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public DateTime JoinedDate { get; set; }
        public int RoleId { get; set; }
    }
}
