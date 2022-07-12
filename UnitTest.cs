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
        Console.WriteLine(user.ToString());
        int number = 0 ;
        if(int.TryParse(user, out number) && number == 1)
        {   
            Console.WriteLine("Number:");
            Console.WriteLine(number);
            Assert.IsTrue(true);
        }
        else
        {   
            Console.WriteLine("Number:");
            Console.WriteLine(number);
            Assert.IsTrue(false);
        }
    }
    [TestMethod]
    public void Test3()
    {
        Assert.IsTrue(true);
    }
}