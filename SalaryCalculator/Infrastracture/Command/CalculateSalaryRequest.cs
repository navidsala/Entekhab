using MediatR;

namespace SalaryCalculator.Infrastracture.Command
{
    public class CalculateSalaryRequest :IRequest
    {
        public UserSalaryCalculatorCommand Data { get; set; }
        public string OverTimeCalculator { get; set;} = string.Empty;
    }
}
