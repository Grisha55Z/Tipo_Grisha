using FirstUnitTest;
namespace UnitTest5
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuadraticEducationA1B2C1_ComparisonOfRoots()
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(1, 2, 1);
            double expected = equation.roots[0];
            Assert.AreEqual(expected, -1);
        }
    }
}