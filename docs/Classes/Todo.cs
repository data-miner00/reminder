using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Todo - A task that is self assigned and is deemed
 *  optional and completion is not necessary
 */

namespace TodoModelling
{
    public class Todo: AbandonableTask
    {
        // Constructor
        public Todo(string title, string priority) : base(title, priority) { }
    }
}
