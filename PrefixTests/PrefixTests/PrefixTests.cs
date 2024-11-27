using PrefixConverter;
using Shouldly;
using System.Reflection;

namespace PrefixTests;

[TestCategory("Prefix")]
[TestClass]
public class PrefixTests
{
    [TestMethod]
    public void PrefixToPostfix1()
    {
        string input = "*-AB+CD";
        var result = new Prefix().ToPostfix(input);
        result.ShouldBe("AB-CD+*");

        Console.WriteLine($"Prefix: {input}");
        Console.WriteLine($"Postfix: {result}");
    }

    [TestMethod]
    public void PrefixToPostfix2()
    {
        string input = "+a*-*bc*/d+efgh";
        var result = new Prefix().ToPostfix(input);
        result.ShouldBe("abc*def+/g*-h*+");

        Console.WriteLine($"Prefix: {input}");
        Console.WriteLine($"Postfix: {result}");
    }

    [TestMethod]
    public void PrefixToInfix1()
    {
        string input = "*-AB+CD";
        var result = new Prefix().ToInfix(input);
        result.ShouldBe("((A-B)*(C+D))");

        Console.WriteLine($"Prefix: {input}");
        Console.WriteLine($"Infix: {result}");
    }

    [TestMethod]
    public void PrefixToInfix2()
    {
        string input = "+a*-*bc*/d+efgh";
        var result = new Prefix().ToInfix(input);
        result.ShouldBe("(a+(((b*c)-((d/(e+f))*g))*h))");

        Console.WriteLine($"Prefix: {input}");
        Console.WriteLine($"Infix: {result}");
    }

    [TestMethod]
    public void CalculatePrefix()
    {
        string input = "+ 100 * - * 13 10 * / 4 + 5 55 20 12";
        var result = new Prefix().CalculateResult(input);
        result.ShouldBe("1644.0000000000000000000000000");

        Console.WriteLine($"Prefix: {input}");
        Console.WriteLine($"Calculation: {new Prefix().CalculateResult(input)}");
    }
}
