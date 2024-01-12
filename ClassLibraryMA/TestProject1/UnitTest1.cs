using ClassLibraryMA;
namespace TestProject1
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
            Class1 class1 = new Class1();
            double expected = class1.div(12, 6);
            Assert.AreEqual(expected, 2);
            Assert.Pass();

        }
        [Test]
        public void Test2()
        {
            Class1 class2 = new Class1();
            double expected = class2.div(16, 2);
            Assert.AreEqual(expected, 8);
            Assert.Pass();

        }
        [Test]
        public void Test3()
        {
            Class1 class3 = new Class1();
            double expected = class3.div(18, 2);
            Assert.AreEqual(expected, 9);
            Assert.Pass();

        }
        [Test]
        public void Test4()
        {
            Class1 class4 = new Class1();
            double expected = class4.div(10, 2);
            Assert.AreEqual(expected, 5);
            Assert.Pass();

        }
        [Test]
        public void Test5()
        {
            Class1 class5 = new Class1();
            double expected = class5.div(12, 2);
            Assert.AreEqual(expected, 6);
            Assert.Pass();

        }
    }
}