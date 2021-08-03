using MaximumValue;
using NUnit.Framework;

namespace MaximumValueTest
{
    public class Tests
    {
        FindMax check = new FindMax();
        //Assign
        //Act
        //Assert

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void GivenMaxIntegerFirstPosition_whenFindMaxInteger_shouldReturnsFirstValue()
        {
            int actualMax = check.Maximum(30, 20, 10);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerSecondPosition_whenFindMaxInteger_shouldReturnsSecondValue()
        {
            int actualMax = check.Maximum(20, 30, 10);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerThirdPosition_whenFindMaxInteger_shouldReturnsThirdValue()
        {
            int actualMax = check.Maximum(20, 10, 30);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatFirstPosition_whenFindMaxFloat_shouldReturnsFirstValue()
        {
            double actualMax = check.Maximum(30.00, 20.00, 10.00);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatSecondPosition_whenFindMaxFloat_shouldReturnsSecondValue()
        {
            double actualMax = check.Maximum(20.00, 30.00, 10.00);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatThirdPosition_whenFindMaxFloat_shouldReturnsThirdValue()
        {
            double actualMax = check.Maximum(20.00, 10.00, 30.00);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_whenFindMaxString_shouldReturnsFirstValue()
        {
            string actualMax = check.Maximum("Peach","Apple","Banana");
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_whenFindMaxString_shouldReturnsSecondValue()
        {
            string actualMax = check.Maximum("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_whenFindMaxString_shouldReturnsThirdValue()
        {
            string actualMax = check.Maximum("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", actualMax);
        }
    }
}