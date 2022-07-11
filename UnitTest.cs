namespace TestMock;

[TestClass]
public class UnitTest
{   
    [TestMethod]
    public void Test1()
    {
        var user = Environment.GetEnvironmentVariable("user");
        //Console.WriteLine("AHOOOOOOJ");
        Assert.IsTrue(user == "user");
    }
    [TestMethod]
    public void Test2()
    {
        Assert.IsTrue(true);
    }
    [TestMethod]
    public void Test3()
    {
        Assert.IsTrue(true);
    }
}