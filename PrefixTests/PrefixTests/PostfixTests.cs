using PrefixConverter;
using Shouldly;

namespace PrefixTests;

[TestCategory("Postfix")]
[TestClass]
public class PostfixToPrefixTests
{
    [TestMethod]
    public void PostfixToPrefix1()
    {
        string input = "A B + C D - *";
        var result = new Postfix().ToPrefix(input);
        result.ShouldBe("* + A B - C D");

        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Prefix: {result}");
    }

    [TestMethod]
    public void PostfixToPrefix2()
    {
        string input = "a b c * d e f + / g * - h * +";
        var result = new Postfix().ToPrefix(input);
        result.ShouldBe("+ a * - * b c * / d + e f g h");

        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Prefix: {result}");
    }

    [TestMethod]
    public void PostfixToInfix1()
    {
        string input = "A B + C D - *";
        var result = new Postfix().ToInfix(input);
        result.ShouldBe("((A+B)*(C-D))");

        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Infix: {result}");
    }

    [TestMethod]
    public void PostfixToInfix2()
    {
        string input = "a b c * d e f + / g * - h * +";
        var result = new Postfix().ToInfix(input);
        result.ShouldBe("(a+(((b*c)-((d/(e+f))*g))*h))");

        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Infix: {result}");
    }

    [TestMethod]
    public void CalculatePostfix()
    {
        string input = "100 13 10 * 4 5 55 + / 20 * - 12 * +";
        var result = new Postfix().CalculateResult(input);
        result.ShouldBe("1644.0000000000000000000000000");

        Console.WriteLine($"Postfix: {input}");
        Console.WriteLine($"Calculation: {result}");
    }
}
