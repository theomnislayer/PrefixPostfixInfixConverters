using PrefixConverter;
using Shouldly;

namespace PrefixTests;

[TestCategory("Infix")]
[TestClass]
public class InfixTests
{
    [TestMethod]
    public void InfixToPrefix()
    {
        string input = "((A-B)*(C+D))";
        var result = new Infix().ToPrefix(input);
        result.ShouldBe("* - A B + C D");

        Console.WriteLine($"Infix: {input}");
        Console.WriteLine($"Prefix: {result}");
    }
}
