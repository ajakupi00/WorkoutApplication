using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo.Events
{
    public delegate void ErrorDelegate(object sender, ErrorEventArgs args);
    public class ErrorEventArgs : EventArgs
    {
        public Exception Exception { get; set; }

    }
}
