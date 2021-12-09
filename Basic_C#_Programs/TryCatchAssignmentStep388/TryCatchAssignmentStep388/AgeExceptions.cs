using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignmentStep388
{
    public class AgeExceptions : Exception
    {
        public AgeExceptions()
            : base() { }
        public AgeExceptions(string message)
            : base(message) { }
    }
}
