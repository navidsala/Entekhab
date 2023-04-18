using AutoMapper;
using MediatR;
using OvetimePolicies;
using SalaryCalculator.Infrastracture.Command;
using SalaryCalculator.Infrastracture.DTO;
using SalaryCalculator.Infrastracture.Model;
using SalaryCalculator.Infrastracture.Repository.Contracts;

namespace SalaryCalculator.Infrastracture
{
    public class SalaryHandler :
        IRequestHandler<CalculateSalaryRequest>,
        IRequestHandler<GetUseSalaryQuery , UserSalaryDTO>
    {
        private readonly IMapper _mapper;
        private readonly ISalaryRepository _salartRepository;
        public SalaryHandler(IMapper mapper , ISalaryRepository salaryRepository)
        {
            _mapper = mapper;
            _salartRepository = salaryRepository;
        }

        public async Task<Unit> Handle(CalculateSalaryRequest request, CancellationToken cancellationToken)
        {
            var method = (dynamic)null;
            if (request.OverTimeCalculator == "a")
            {
                 method = new CalculateOvertimeMethod1();
                //var overtime = new CalcMethod(method);
            }
            if (request.OverTimeCalculator == "b")
            {
                 method = new CalculateOvertimeMethod2();
                //var overtime = new CalcMethod(method);
            }
            var overtime = new CalcMethod(method);
            var data = _mapper.Map<Salary>(request);
            data.TotalSalary = calculateBasisSalary(request, overtime.CalculateOverTime());
            _salartRepository.CreateAsync(data).Wait();

            return Unit.Value;
        }

        public async Task<UserSalaryDTO> Handle(GetUseSalaryQuery request, CancellationToken cancellationToken)
        {
            var lastRow = _salartRepository.SelectByUserId<Salary>(request.UserId).Result.FirstOrDefault();
            var data = await _salartRepository.SelectById<Salary>(lastRow.SalaryId);
            var res = _mapper.Map<UserSalaryDTO>(data);
            return res;
        }

        private int calculateBasisSalary(CalculateSalaryRequest data  ,int  overtimeValve) {
            var basis = data.Data.BasicSalary + data.Data.Allowance + data.Data.Transportation + overtimeValve;
            return basis - ((int)basis * 0/25);
        }
    }
}
