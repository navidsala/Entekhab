using MediatR;
using SalaryCalculator.Infrastracture.DTO;

namespace SalaryCalculator.Infrastracture
{
    public class GetUseSalaryQuery: IRequest<UserSalaryDTO>
    {
        public int UserId { get; set; }

    }
}
