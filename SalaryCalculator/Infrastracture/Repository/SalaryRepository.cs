using SalaryCalculator.Infrastracture.Data;
using SalaryCalculator.Infrastracture.Model;
using SalaryCalculator.Infrastracture.Repository.Contracts;

namespace SalaryCalculator.Infrastracture.Repository
{
    public class SalaryRepository:Repository<Salary> , ISalaryRepository
    {
        public SalaryRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
