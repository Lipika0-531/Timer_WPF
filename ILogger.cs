using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollyTracker
{
    public interface ILogger
    {
        public void LogMessage(Task parameters);
    }
}
