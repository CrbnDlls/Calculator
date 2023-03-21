using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double GetResult(IEnumerable<Command> commands)
        { 
            double result = double.NaN;
            bool IsFirst = true;
            Operation operation = Operation.No;
            foreach (Command command in commands)
            {
                if (IsFirst)
                {
                    result = command.Value;
                    operation = command.Operation;
                    IsFirst = false;
                    continue;
                }

                result = GetResult(result, command.Value, operation);
                
                operation = command.Operation;
            }

            return result;
        }

        private double GetResult(double operand1, double operand2, Operation operation)
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
        Divide,
        No
    }
}
