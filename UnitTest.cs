namespace TestMock;

[TestClass]
public class UnitTest
{   
    [TestMethod]
    public void Test1()
    {
        Assert.IsTrue(true);
    }
    [TestMethod]
    public void Test2()
    {
        var user = Environment.GetEnvironmentVariable("USER",EnvironmentVariableTarget.Process);
        Console.WriteLine("user:");
        Console.WriteLine(user);
        Assert.AreSame(expected:"USER",actual:user);
    }
    [TestMethod]
    public void Test3()
    {
        Assert.IsTrue(true);
    }
}