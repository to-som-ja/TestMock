namespace TestMock;

[TestClass]
public class UnitTest
{   
    [TestMethod]
    public void Test1()
    {
        string? test = Environment.GetEnvironmentVariable("TEST1",EnvironmentVariableTarget.Process);
        bool pass = false ;
        Assert.IsTrue(bool.TryParse(test, out pass) && pass);
    }
    [TestMethod]
    public void Test2()
    {
        string? test = Environment.GetEnvironmentVariable("TEST2",EnvironmentVariableTarget.Process);
        bool pass = false ;
        Assert.IsTrue(bool.TryParse(test, out pass) && pass);
    }
    [TestMethod]
    public void Test3()
    {
        string? test = Environment.GetEnvironmentVariable("TEST3",EnvironmentVariableTarget.Process);
        bool pass = false ;
        Assert.IsTrue(bool.TryParse(test, out pass) && pass);
    }
}