using example;
namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("I AM A TEST");
        Assert.Equal(Example.foo(), "Hello World");
    }
}