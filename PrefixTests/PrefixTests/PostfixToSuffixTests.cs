using PrefixConverter;

namespace PrefixTests;

[TestClass]
public class PostfixToPrefixTests
{
    [TestMethod]
    public void PostfixToPrefix1()
    {
        string input = "AB+CD-*";
        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Prefix: {new Postfix().ToPrefix(input)}");
    }

    [TestMethod]
    public void PostfixToInfix1()
    {
        string input = "AB+CD-*";
        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Infix: {new Postfix().ToInfix(input)}");
    }
}
