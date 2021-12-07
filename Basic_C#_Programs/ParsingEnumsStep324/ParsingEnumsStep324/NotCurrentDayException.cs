using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsStep324
{
    class NotCurrentDayException : Exception
    {
        public NotCurrentDayException() { }

        public NotCurrentDayException(string message)
            : base(message) { }

        public NotCurrentDayException(string message, Exception inner)
            : base(message, inner) { }
    }
}
