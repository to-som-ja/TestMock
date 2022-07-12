namespace TestMock;

[TestClass]
public class UnitTest
{   
    Random rnd = new Random();

    [TestMethod]
    public void Test1()
    {
        string? test = Environment.GetEnvironmentVariable("TEST1",EnvironmentVariableTarget.Process);
        int number;
        int.TryParse(test, out number);
        Assert.IsTrue(rnd.Next(100)<number);
    }
    [TestMethod]
    public void Test2()
    {
        string? test = Environment.GetEnvironmentVariable("TEST2",EnvironmentVariableTarget.Process);
        int number;
        int.TryParse(test, out number);
        Assert.IsTrue(rnd.Next(100)<number);
    }
    [TestMethod]
    public void Test3()
    {
        string? test = Environment.GetEnvironmentVariable("TEST3",EnvironmentVariableTarget.Process);
        int number;
        int.TryParse(test, out number);
        Assert.IsTrue(rnd.Next(100)<number);
    }

    [TestMethod]
    public void Test4()
    {   
        string? test = Environment.GetEnvironmentVariable("TEST4",EnvironmentVariableTarget.Process);
        int number;
        int.TryParse(test, out number);
        Assert.IsTrue(rnd.Next(100)<number);
    }
}