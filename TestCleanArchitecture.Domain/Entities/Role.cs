using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities.Base;

namespace TestCleanArchitecture.Domain.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public int PermissionLevel { get; set; }
    }
}
