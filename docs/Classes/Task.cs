using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoModelling
{
    public abstract class Task
    {
        protected static int generateId()
        {
            return 1;
        }

        protected static string todayDate()
        {
            return "1/02/1970";
        }

        // Unique ID
        public int Id { get; set; } 

        // Title of task
        public string Title { get; set; }

        // Date issued
        public string Created { get; set; }

        // Assigned priority { LOW, MEDIUM, HIGH }
        public string Priority { get; set; }
        
        // Determine wheather the specified task has been done
        public bool IsDone { get; set; }
        
        // The date when the task is done, initially set to null
        public string Completed { get; set; }

        // Constructor
        public Task(string title, string priority)
        {
            Id = generateId();
            Title = title;
            Created = todayDate();
            Priority = priority;
            IsDone = false;
            Completed = "";
        }

        // Methods

        // The task can be completed once it is completed
        public void Done() { }

        // The task can be updated
        public void Update() { }

        // The task can be deleted 
        public void Delete() { }
    }
}
