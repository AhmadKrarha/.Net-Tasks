namespace Tasks_MVC_one.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string PhotoPath { get; set; }
        public DateTime EntryDate { get; set; }
        public string Password { get; set; } // Note: Consider hashing this in practice

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}
