using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollyTracker
{
    public class Task
    {
        public DateOnly date {  get; set; }

        public TimeOnly TotalWorkingHours { get; set; }
        public string Notes { get; set; }

        public string ProjectName { get; set; }

        public string TaskList { get; set; }

        public string TaskName { get; set; }

        public BillStatus BillStatus { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public States state { get; set; }

    }
}
