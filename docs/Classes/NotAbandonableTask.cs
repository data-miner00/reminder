using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoModelling
{
    public abstract class NotAbandonableTask: Task
    {
        // Constructor
        public NotAbandonableTask(string title, string priority) :
            base(title, priority)
        { }
    }
}
