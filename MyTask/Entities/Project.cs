using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project : Base
    {
        public string Description { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual int CustomerID { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}
