using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Project - is a to-do that requires building the tangible product
 *  in the form of repositories
 */

namespace TodoModelling
{
    public class Project: AbandonableTask
    {

        // Constructor
        public Project(string title, string priority) : base(title, priority) { }

    }
}
