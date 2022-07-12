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
        string user = Environment.GetEnvironmentVariable("USER",EnvironmentVariableTarget.Process);
        Console.WriteLine("user:");
        Console.WriteLine(user.ToString());
        Assert.AreSame("USER",user.ToString());
    }
    [TestMethod]
    public void Test3()
    {
        Assert.IsTrue(true);
    }
}