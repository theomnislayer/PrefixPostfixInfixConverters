namespace PrefixConverter;

public class Prefix : ConverterBase
{
    public string ToPostfix(string input)
    {
        Stack<string> myStack = new();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (IsOperator(input[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();

                myStack.Push($"{operand1}{operand2}{input[i]}");
            }
            else
                myStack.Push(input[i].ToString());
        }
        return myStack.Pop();
    }

    public string ToInfix(string input)
    {
        Stack<string> myStack = new();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (IsOperator(input[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();
                myStack.Push($"({operand1}{input[i]}{operand2})");
            }
            else
                myStack.Push(input[i].ToString());
        }
        return myStack.Pop();
    }
}