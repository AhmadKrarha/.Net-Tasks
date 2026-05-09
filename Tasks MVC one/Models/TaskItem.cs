namespace Tasks_MVC_one.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public int ImportanceLevel { get; set; } // 1-5 scale or enum

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
