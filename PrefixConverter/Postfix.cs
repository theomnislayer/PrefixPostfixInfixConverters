namespace PrefixConverter;

public class Postfix : ConverterBase
{
    Stack<string> myStack = new();
    
    public string ToPrefix(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (IsOperator(input[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();

                myStack.Push($"{input[i]}{operand2}{operand1}");
            }
            else
                myStack.Push(input[i].ToString());
        }
        return myStack.Pop();
    }

    public string ToInfix(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (IsOperator(input[i]))
            {
                string operand1 = myStack.Pop();
                string operand2 = myStack.Pop();

                myStack.Push($"({operand2}{input[i]}{operand1})");
            }
            else
                myStack.Push(input[i].ToString());
        }
        return myStack.Pop();
    }
}