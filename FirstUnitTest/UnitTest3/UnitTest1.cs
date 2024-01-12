using FirstUnitTest;
namespace UnitTest3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuadraticEducationA1B2C1_NumbersOfRoots1()
        {
            TheQuadraticEquation equation = new TheQuadraticEquation(1, 2, 1);
            int expected = equation.roots.Length;
            Assert.AreEqual(expected, 1);

        }
    }
}