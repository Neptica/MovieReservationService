using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities.Base;

namespace TestCleanArchitecture.Domain.Entities
{
    public class Connection : Entity
    {
        public int InitFriendId { get; set; }
        public int RecFriendId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime AcceptedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
