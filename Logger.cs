using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollyTracker
{
    public class Logger : ILogger
    {
        /// <summary>
        /// File Path.
        /// </summary>
        public string FilePath;

        public Logger(string filePath)
        {
            FilePath = filePath;
        }

        /// <summary>
        /// Logs data to file.
        /// </summary>
        /// <param name="message">Message to log</param>
        public void LogMessage(Task parameters)
        {
            string timestamp = DateTime.Now.ToString();
            string logEntry = $"{timestamp},{parameters.ProjectName}, {parameters.TaskName} , {parameters.TaskList}, {parameters.BillStatus}, {parameters.StartTime}, {parameters.EndTime}, {parameters.state}";
            using StreamWriter writer = File.AppendText(FilePath);
            writer.WriteLine(logEntry);
        }
    }
}
