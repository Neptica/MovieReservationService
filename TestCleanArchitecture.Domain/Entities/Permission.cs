using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationService.Domain.Entities.Base;

namespace MovieReservationService.Domain.Entities
{
    public class Permission : Entity
    {
        public string ActionName { get; set; }
        public int SecurityLevelRequired { get; set; }
    }
}
