using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Mustdo - An self assigned todos such that the completion
 *  of itself is deemed necessary and important.
 */

namespace TodoModelling
{
    public class Mustdo: NotAbandonableTask
    {
        // Constructor
        public Mustdo(string title, string priority) : base(title, priority) { }
    }
}
