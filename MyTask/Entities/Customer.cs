using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Base
    {
        public string Email { get; set; }
        public string Company { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
