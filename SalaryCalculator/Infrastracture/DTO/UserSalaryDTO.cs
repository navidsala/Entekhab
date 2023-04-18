namespace SalaryCalculator.Infrastracture.DTO
{
    public class UserSalaryDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int BasicSalary { get; set; }
        public int Allowance { get; set; }
        public int Transportation { get; set; }
        public DateTime Date { get; set; }
        public int TotalSalary { get; set; }
    }
}
