namespace PrefixConverter;
public class ConverterBase
{
    public bool LogSteps { get; set; } = false;

    public bool IsOperator(char value)
    {
        return value switch
        {
            '+' => true,
            '-' => true,
            '*' => true,
            '/' => true,
            '^' => true,
            '%' => true,
            _ => false,
        };
    }

    public bool IsOperator(string value)
    {
        if(value.Length == 1)
            return IsOperator(value[0]);
        return false;
    }

    public decimal Calculate(char sign, string operand1, string operand2)
    {
        decimal val1 = decimal.Parse(operand1);
        decimal val2 = decimal.Parse(operand2);

        return sign switch
        {
            '+' => val1 + val2,
            '-' => val1 - val2,
            '*' => val1 * val2,
            '/' => val1 / val2,
            //'^' => val1 ^ val2, //Not Supported Yet.
            '%' => val1 % val2,
            _ => throw new Exception("Invalid Operand"),
        };
    }

    public decimal Calculate(string sign, string operand1, string operand2)
    {
        var result = Calculate(sign[0], operand1, operand2);
        return result;
        //return Calculate(sign[0], operand1, operand2);
    }
}
