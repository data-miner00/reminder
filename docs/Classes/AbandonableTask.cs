using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoModelling
{
    public abstract class AbandonableTask: Task
    {

        // Constructor
        public AbandonableTask(string title, string priority) :
            base(title, priority)
        { }

        // Abandon method
        public void Abandon() { }
    }
}
