using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecordStructs.InterpolationHandler
{
    [InterpolatedStringHandler]
    public class LoggerInterpolationHandler
    {
        private StringBuilder builder;

        public LoggerInterpolationHandler(int literalLength, int formattedCount)
        {
            builder = new StringBuilder(literalLength);
            Console.WriteLine($"String has LiteralLength - {literalLength}\nAnd Formatted Count - {formattedCount}");
        }

        public void AppendLiteral(string s) 
        {
            Console.WriteLine($"\nLiteral String - {s}");
            builder.Append(s);
        }

        public void AppendFormatted<T>(T t)
        {
            Console.WriteLine($"\nAppended Formated {t} of Type - {typeof(T)}");

            builder.Append(t?.ToString());
        }

        internal string GetInterpolatedText() => builder.ToString();
    }
}
