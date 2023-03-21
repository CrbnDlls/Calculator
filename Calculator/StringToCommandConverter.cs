using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringToCommandConverter
    {
        private readonly List<Command> commands;

        public StringToCommandConverter()
        {
            commands = new List<Command>();
        }

        public List<Command> Convert(string input)
        {
            if(commands.Count > 0)
            {
                commands.Clear();
            }

            string[] values = input.Split('/', '*', '+', '-');

            foreach (string value in values)
            {
                int operationIndex = input.IndexOfAny(new[] { '/', '*', '+', '-' });

                Command command = new Command();
                command.Value = double.Parse(value);
                if (operationIndex != -1)
                {
                    switch (input[operationIndex])
                    {
                        case '+':
                            command.Operation = Operation.Add;
                            break;
                        case '-':
                            command.Operation = Operation.Subtract;
                            break;
                        case '/':
                            command.Operation = Operation.Divide;
                            break;
                        case '*':
                            command.Operation = Operation.Multiply;
                            break;
                    }
                }
                else
                {
                    command.Operation = Operation.No;
                }

                commands.Add(command);
                input = input.Substring(operationIndex + 1);
            }

            return commands;
        }
    }
}
