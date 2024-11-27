namespace PrefixConverter;

public class Prefix : ConverterBase
{
    public string ToPostfix(string input)
    {
        string[] inputs = input.Trim().Split(' ');
        Stack<string> myStack = new();

        for (int i = inputs.Length - 1; i >= 0; i--)
        {
            if (IsOperator(inputs[i].Trim()))
            {
                string operand1 = myStack.Pop().Trim();
                string operand2 = myStack.Pop().Trim();

                myStack.Push($"{operand1} {operand2} {inputs[i]} ");
            }
            else
                myStack.Push(inputs[i].ToString());
        }
        return myStack.Pop().Trim();
    }

    public string ToInfix(string input)
    {
        string[] inputs = input.Trim().Split(' ');
        Stack<string> myStack = new();

        for (int i = inputs.Length - 1; i >= 0; i--)
        {
            if (IsOperator(inputs[i].Trim()))
            {
                string operand1 = myStack.Pop().Trim();
                string operand2 = myStack.Pop().Trim();
                myStack.Push($"({operand1}{inputs[i]}{operand2})");
            }
            else
                myStack.Push(inputs[i].ToString());
        }
        return myStack.Pop().Trim();
    }

    public string CalculateResult(string input)
    {
        string[] inputs = input.Trim().Split(' ');
        Stack<string> myStack = new();
        for (int i = inputs.Length - 1; i >= 0; i--)
        {
            if (IsOperator(inputs[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();

                myStack.Push(Calculate(inputs[i], operand1, operand2).ToString());
            }
            else
                myStack.Push(inputs[i]);
        }

        return myStack.Pop().Trim();
    }
}