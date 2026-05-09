using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public int PermissionLevel { get; set; }
    }
}
