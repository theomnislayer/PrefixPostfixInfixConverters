namespace PrefixConverter;

public class Postfix : ConverterBase
{
    public string ToPrefix(string input)
    {
        string[] inputs = input.Trim().Split(' ');
        Stack<string> myStack = new();

        for (int i = 0; i < inputs.Length; i++)
        {
            if (IsOperator(inputs[i].Trim()))
            {
                string operand1 = myStack.Pop().Trim();
                string operand2 = myStack.Pop().Trim();

                myStack.Push($"{inputs[i]} {operand2} {operand1} ");
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

        for (int i = 0; i < inputs.Length; i++)
        {
            if (IsOperator(inputs[i].Trim()))
            {
                string operand1 = myStack.Pop().Trim();
                string operand2 = myStack.Pop().Trim();

                myStack.Push($"({operand2}{inputs[i]}{operand1})");
            }
            else
                myStack.Push(inputs[i].ToString());
        }
        return myStack.Pop().Trim();
    }

    public string CalculateResult(string input)
    {
        string[] inputs = input.Split(' ');
        Stack<string> myStack = new();
        for (int i = 0; i <= inputs.Length - 1; i++)
        {
            if (IsOperator(inputs[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();

                myStack.Push(Calculate(inputs[i], operand2, operand1).ToString());
            }
            else
                myStack.Push(inputs[i]);
        }

        return myStack.Pop().Trim();
    }
}