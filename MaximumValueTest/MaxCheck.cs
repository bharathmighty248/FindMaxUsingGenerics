using MaximumValue;
using NUnit.Framework;

namespace MaximumValueTest
{
    public class Tests
    {
        //Assign
        //Act
        //Assert

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void GivenMaxIntegerFirstPosition_whenFindMaxInteger_shouldReturnsFirstValue()
        {
            FindMax<int> check = new FindMax<int>(30, 20, 10);
            int actualMax = check.Maximum();
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerSecondPosition_whenFindMaxInteger_shouldReturnsSecondValue()
        {
            FindMax<int> check = new FindMax<int>(20, 30, 10);
            int actualMax = check.Maximum();
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerThirdPosition_whenFindMaxInteger_shouldReturnsThirdValue()
        {
            FindMax<int> check = new FindMax<int>(20, 10, 30);
            int actualMax = check.Maximum();
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatFirstPosition_whenFindMaxFloat_shouldReturnsFirstValue()
        {
            FindMax<double> check = new FindMax<double>(30.00, 20.00, 10.00);
            double actualMax = check.Maximum();
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatSecondPosition_whenFindMaxFloat_shouldReturnsSecondValue()
        {
            FindMax<double> check = new FindMax<double>(20.00, 30.00, 10.00);
            double actualMax = check.Maximum();
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatThirdPosition_whenFindMaxFloat_shouldReturnsThirdValue()
        {
            FindMax<double> check = new FindMax<double>(20.00, 10.00, 30.00);
            double actualMax = check.Maximum();
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_whenFindMaxString_shouldReturnsFirstValue()
        {
            FindMax<string> check = new FindMax<string>("Peach", "Apple", "Banana");
            string actualMax = check.Maximum();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_whenFindMaxString_shouldReturnsSecondValue()
        {
            FindMax<string> check = new FindMax<string>("Apple", "Peach", "Banana");
            string actualMax = check.Maximum();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_whenFindMaxString_shouldReturnsThirdValue()
        {
            FindMax<string> check = new FindMax<string>("Apple", "Banana", "Peach");
            string actualMax = check.Maximum();
            Assert.AreEqual("Peach", actualMax);
        }
    }
}