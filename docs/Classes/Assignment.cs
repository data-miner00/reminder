using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Assignments, is a special kind of project or mustdos that is
 *  given by the school that completion is necessary
 */

namespace TodoModelling
{
    public class Assignment: NotAbandonableTask
    {

        // The due date as specified by the lecturer
        public DateTime Due { get; set; }

        // Course associated with this assignment
        public string Course { get; set; }

        // Constructor
        public Assignment(string title, string priority, DateTime due, string course) :
            base(title, priority)
        {
            Due = due;
            Course = course;
        }
    }
}
