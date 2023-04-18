using MediatR;
using Microsoft.AspNetCore.Mvc;
using SalaryCalculator.Infrastracture;
using SalaryCalculator.Infrastracture.Command;

namespace SalaryCalculator.Controllers
{
    [ApiController]
    [Route("api/json/[controller]")]
    public class SalaryController : Controller
    {
        private readonly IMediator _mediator;
        public SalaryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CalculateAndSaveSalary")]
        public async Task<IActionResult> AddSalary(CalculateSalaryRequest userSalaryCalculator)
        {
            if(!ModelState.IsValid)
                throw new Exception(ModelState.ToString());

            await _mediator.Send(userSalaryCalculator);

            return Ok();
        }
        [HttpGet]
        [Route("GetUserData")]
        public async Task<IActionResult> GetSalary(GetUseSalaryQuery userSalary)
        {
            var data =  await _mediator.Send(userSalary);
            return Ok(data);
        }
    }
}
