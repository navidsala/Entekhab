using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvetimePolicies
{
    public class CalcMethod
    {
        IOvertimeCalculatorMethod _overtimeCalculatorMethod;
        public CalcMethod(IOvertimeCalculatorMethod overtimeCalculatorMethod)
        {
            _overtimeCalculatorMethod = overtimeCalculatorMethod;
        }
        public int CalculateOverTime()
        {
            return _overtimeCalculatorMethod.CalculateOverTime();
        }
    }
}
