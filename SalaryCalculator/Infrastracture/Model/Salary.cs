namespace SalaryCalculator.Infrastracture.Model
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int BasicSalary { get; set; }
        public int Allowance { get; set; }
        public int Transportation { get; set; }
        public DateTime Date { get; set; }
        public int TotalSalary { get; set; }
    }
}
