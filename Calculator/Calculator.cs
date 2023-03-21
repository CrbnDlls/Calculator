using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static double GetResult(double operand1, double operand2, Operation operation)
        {
            double result = double.NaN;
            switch (operation)
            {
                case Operation.Add:
                    result = operand1 + operand2;
                    break;
                case Operation.Subtract:
                    result = operand1 - operand2;
                    break;
                case Operation.Multiply:
                    result = operand1 * operand2;
                    break;
                case Operation.Divide:
                    result = operand1 / operand2;
                    break;
            }
            return result;
        }
    }

    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
