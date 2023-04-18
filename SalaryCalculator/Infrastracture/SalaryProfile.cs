using AutoMapper;
using SalaryCalculator.Infrastracture.Command;
using SalaryCalculator.Infrastracture.DTO;
using SalaryCalculator.Infrastracture.Model;

namespace SalaryCalculator.Infrastracture
{
    public class SalaryProfile: Profile
    {
        public SalaryProfile()
        {
            CreateMap<UserSalaryCalculatorCommand, Salary>();
            CreateMap<Salary, UserSalaryDTO>();
        }
    }
}
