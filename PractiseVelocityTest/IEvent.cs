using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity
{
    /// <summary>
    /// This Event interface has to be implemented by all the event types, so that the methods 
    /// declared here are implemented in the derived classes.
    /// </summary>
    interface IEvent

    {
        String  GenerateMultiples();
    }
}
