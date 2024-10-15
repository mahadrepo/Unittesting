using Xunit;
using SimpleFunctionApp;  // This should match your main project's namespace

public class UnitTest1
{
    [Fact]
    public void TestAddNumbers()
    {
        // Arrange
        int a = 30;
        int b = 20;

        // Act
        int result = Program.AddNumbers(a, b);

        // Asserts
        Assert.Equal(50, result);
    }
}
