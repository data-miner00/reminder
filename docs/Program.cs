using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoModelling
{
    class Program
    {
        static IList<Task> tasks = new List<Task>();

        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the TodoModeling Documentation");

            PopulateList();

            Console.WriteLine("All the tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task.Id + " -- " + task.Title);
            }
            Console.WriteLine();

            Console.WriteLine("Abandonable tasks:");
            var filter = from task in tasks
                         where task is AbandonableTask
                         select task;
            foreach (var task in filter)
            {
                Console.WriteLine(task.Id + " -- " + task.Title);
            }

        }

        static void PopulateList()
        {
            tasks.Add(new Todo("Read books", "Medium"));
            tasks.Add(new Mustdo("Plant trees", "Low"));
            tasks.Add(new Assignment("Make a Web App", "Extremely Low", new DateTime(2022, 3, 4), "UECS1234"));
            tasks.Add(new Project("Make a Reminder App", "Extremely High"));
            Console.WriteLine("Sucessfully populated");
        }
    }
}
