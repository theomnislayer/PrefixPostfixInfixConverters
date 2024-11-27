namespace PrefixConverter;
public class ConverterBase
{
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
}
