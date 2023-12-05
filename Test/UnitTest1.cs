using App;

namespace Test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine(Environment.GetEnvironmentVariable("SECRET"));
        Assert.Equal("Hello, World!", Program.Greet());
    }
}