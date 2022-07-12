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
        string? user = Environment.GetEnvironmentVariable("USER",EnvironmentVariableTarget.Process);
        Console.WriteLine("user:");
        Console.WriteLine(user);
        if(user == "USER1")
        {
            Assert.IsTrue(true);
        }
        else
        {
            Assert.IsTrue(false);
        }
    }
    [TestMethod]
    public void Test3()
    {
        Assert.IsTrue(true);
    }
}