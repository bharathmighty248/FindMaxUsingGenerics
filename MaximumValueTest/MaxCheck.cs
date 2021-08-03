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
        public void GivenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int actualMax = check.Maximum(30, 20, 10);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int actualMax = check.Maximum(20, 30, 10);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            int actualMax = check.Maximum(20, 10, 30);
            Assert.AreEqual(30, actualMax);
        }
    }
}