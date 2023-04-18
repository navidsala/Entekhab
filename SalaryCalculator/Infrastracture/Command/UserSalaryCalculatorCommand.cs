namespace SalaryCalculator.Infrastracture.Command
{
    public class UserSalaryCalculatorCommand
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int BasicSalary { get; set; }
        public int Allowance { get; set; }
        public int Transportation { get; set; }
        public DateTime Date { get; set; }
    }
}
