using App;

namespace Test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Steven", Environment.GetEnvironmentVariable("SECRET"));
        Assert.Equal("Hello, World!", Program.Greet());
    }
}