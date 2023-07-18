namespace TaskManager
{
    public class BaseClass
    {
        public string? Day { get; set; }
        public DateTime? Date { get; set; }= DateTime.Now;
        public string? Task { get; set; }
        public DateOnly? DateScheduled { get; set; }
        public TimeOnly? TimeScheduled { get; set; }
        public BaseClass(string day, string task, DateOnly? dateScheduled, TimeOnly? timeScheduled)
        {
            Day = day;
            Task = task;
            DateScheduled = dateScheduled;
            TimeScheduled = timeScheduled;

        }
    }
}
