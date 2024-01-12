using FirstUnitTest;
namespace UnitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuadraticEducationA3B9C3_NumbersOfRoots2()
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(3, 9, 3);
            int expected = equation.roots.Length;
            Assert.AreEqual(expected, 2);
        }
        
        
       
    }
}