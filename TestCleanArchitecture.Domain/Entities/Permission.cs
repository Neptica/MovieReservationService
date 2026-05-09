using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Entities.Base;

namespace TestCleanArchitecture.Domain.Entities
{
    public class Permission : Entity
    {
        public string ActionName { get; set; }
        public int SecurityLevelRequired { get; set; }
    }
}
