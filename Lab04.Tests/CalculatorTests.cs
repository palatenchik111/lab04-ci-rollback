using Lab04.Api;
using Xunit;

namespace Lab04.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoAndTwo_ReturnsFour()
    {
        int actual = Calculator.Add(2, 2);

        Assert.Equal(4, actual);
    }
}
