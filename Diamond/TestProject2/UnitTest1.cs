using ClassLibrary1;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Class1 clas = new ClassLibrary1.Class1();
            int expected = clas.PoKrasote(5, 2);
            Assert.IsFalse(expected == 5);
            Assert.AreEqual(expected, 3);
            
        }
    }
}