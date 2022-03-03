using CSharpTen.Helpers;
using RecordStructs.InterpolationHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTen.HelperClasses
{
    public class Logger
    {
        public LoggerLevels level { get; init; } = LoggerLevels.Error;

        public Logger()
        {
        }

        public void AddLoggingMessage(LoggerLevels loggedLevel, LoggerInterpolationHandler handler) 
        {
            if (level < loggedLevel) 
            {
                return;
            }

            Console.WriteLine(handler.GetInterpolatedText());
        }
    }
}
