using PrefixConverter;

namespace PrefixTests;

[TestClass]
public class PrefixToPostfixTests
{
    [TestMethod]
    public void PrefixToPostfix1()
    {
        string input = "*-AB+CD";
        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Prefix: {new Prefix().ToPostfix(input)}");
    }

    [TestMethod]
    public void PrefixToInfix1()
    {
        string input = "*-AB+CD";
        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Infix: {new Prefix().ToInfix(input)}");
    }
}
