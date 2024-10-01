using HydacProject;
namespace HydacProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileHandler handler = new FileHandler();
            handler.ReadVisitorFromFile("C:/Users/spilp/Documents/Datamatiker/Visual studio programmer/Projekter/Det rigtige Hydac projekt/Hydac/Visitors.txt");
        }
    }
}