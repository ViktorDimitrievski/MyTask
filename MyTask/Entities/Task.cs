using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WepApp.Models;

namespace Entities
{
    public class Task : Base
    {
        public string Description { get; set; }
        public string EstimatedHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TaskType Type { get; set; }
        public TaskStatus Status { get; set; }
        public string Members { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual string UserID { get; set; }
        public virtual Project Project { get; set; }
        public virtual int ProjectID { get; set; }
    }

    public enum TaskType
    {
        Bug = 0,
        Test = 1,
        NewFeature = 2,
        Suport = 3
    }
    public enum TaskStatus
    {
        ToDo = 0,
        InProgress = 1,
        InTesting = 2,
        Done = 3
    }
}
