using Xunit;
using SimpleFunctionApp;  // This should match your main project's namespace

public class UnitTest1
{
    [Fact]
    public void TestAddNumbers()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = Program.AddNumbers(a, b);

        // Assert
        Assert.Equal(15, result);
    }
}
