using FirstUnitTest;
namespace UnitTest4
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuadraticEducationA3B9C3_ComparisonOfRoots()
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(3, 9, 3);
            double[] results = new double[2] { 54, -81 };
            double[] ExpectedArray = equation.roots;
            Assert.AreEqual(ExpectedArray, results);
        }
    }
}