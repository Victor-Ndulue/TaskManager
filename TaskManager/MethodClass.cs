using System.Data;

namespace TaskManager
{
    public class MethodClass
    {
        private List<BaseClass> ListOfTasks;
        public  MethodClass()
        {
            ListOfTasks = new List<BaseClass>();
            InitializeBaseClass();
        }
        public void InitializeBaseClass()
        {
        repeat3:
            Console.WriteLine("Please enter day");
            var day = Console.ReadLine().ToLower();
            if (day == "wednesday") { Console.WriteLine("Today's assignment submission day"); goto repeat3; }
            if (day == "saturday" || day == "sunday") {Console.WriteLine("Rest Man, you're not machine"); goto repeat3; }
            Console.WriteLine("Please enter Task");
            var task = Console.ReadLine();
            repeat1:
            Console.WriteLine($"Please, enter the date for the task in the format {DateOnly.FromDateTime(DateTime.UtcNow)} ");
            DateOnly dateScheduled;
            var dateSet = DateOnly.TryParse(Console.ReadLine(), out dateScheduled);
            if(!dateSet) goto repeat1;
            repeat2:
            Console.WriteLine($"Please, enter the time for the task in the format {TimeOnly.FromDateTime(DateTime.UtcNow)}");
            TimeOnly timeScheduled;
            var timeSet = TimeOnly.TryParse(Console.ReadLine(),out timeScheduled);
            if (!timeSet) goto repeat2;

            AddTask(day, task, dateScheduled, timeScheduled);
        }
        public void AddTask(string day, string task, DateOnly dateScheduled, TimeOnly timeScheduled) 
        { 
            BaseClass baseClass = new(day,task,dateScheduled,timeScheduled);
            ListOfTasks.Add(baseClass);
        }
        public void PrintTask()
        {
            foreach (var Task in ListOfTasks)
            {
                Console.WriteLine("Day:  " + Task.Day + "Date Created:  " + Task.Date);
                Console.WriteLine("Task:  " + Task.Task  + " Date For Task:  " + Task.DateScheduled + " Time For Task:  " + Task.TimeScheduled + "/n");
            }
        }
    }
}
