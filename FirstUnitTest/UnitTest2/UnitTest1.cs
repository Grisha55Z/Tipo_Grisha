using FirstUnitTest;
namespace UnitTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuadraticEducationA3B2C3_NumbersOfRoots0()
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(3, 2, 3);
            int expected = equation.roots.Length;
            Assert.AreEqual(expected, 0);

        }
    }
}