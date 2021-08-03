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
            int[] intValues = { 30, 20, 10, 5 };
            FindMax<int> findMaxInt = new FindMax<int>(intValues);
            int actualMax= findMaxInt.Maximum(intValues);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerSecondPosition_whenFindMaxInteger_shouldReturnsSecondValue()
        {
            int[] intValues = { 20, 30, 10, 5 };
            FindMax<int> findMaxInt = new FindMax<int>(intValues);
            int actualMax = findMaxInt.Maximum(intValues);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerThirdPosition_whenFindMaxInteger_shouldReturnsThirdValue()
        {
            int[] intValues = { 20, 10, 30, 5 };
            FindMax<int> findMaxInt = new FindMax<int>(intValues);
            int actualMax = findMaxInt.Maximum(intValues);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 1.4
        /// </summary>
        [Test]
        public void GivenMaxIntegerFourthPosition_whenFindMaxInteger_shouldReturnsFourthValue()
        {
            int[] intValues = { 20, 10, 30, 5 };
            FindMax<int> findMaxInt = new FindMax<int>(intValues);
            int actualMax = findMaxInt.Maximum(intValues);
            Assert.AreEqual(30, actualMax);
        }

        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatFirstPosition_whenFindMaxFloat_shouldReturnsFirstValue()
        {
            double[] doubleValues = { 30.00, 20.00, 10.00, 5.00 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleValues);
            double actualMax= findMaxDouble.Maximum(doubleValues);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatSecondPosition_whenFindMaxFloat_shouldReturnsSecondValue()
        {
            double[] doubleValues = { 20.00, 30.00, 10.00, 5.00 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleValues);
            double actualMax = findMaxDouble.Maximum(doubleValues);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatThirdPosition_whenFindMaxFloat_shouldReturnsThirdValue()
        {
            double[] doubleValues = { 20.00, 10.00, 30.00, 5.00 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleValues);
            double actualMax = findMaxDouble.Maximum(doubleValues);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 2.4
        /// </summary>
        [Test]
        public void GivenMaxFloatFourthPosition_whenFindMaxFloat_shouldReturnsFourthValue()
        {
            double[] doubleValues = { 20.00, 10.00, 5.00, 30.00 };
            FindMax<double> findMaxDouble = new FindMax<double>(doubleValues);
            double actualMax = findMaxDouble.Maximum(doubleValues);
            Assert.AreEqual(30.00, actualMax);
        }

        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_whenFindMaxString_shouldReturnsFirstValue()
        {
            string[] stringValues = { "Peach", "Apple", "Banana", "Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringValues);
            string actualMax= findMaxString.Maximum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_whenFindMaxString_shouldReturnsSecondValue()
        {
            string[] stringValues = { "Apple", "Peach", "Banana", "Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringValues);
            string actualMax = findMaxString.Maximum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_whenFindMaxString_shouldReturnsThirdValue()
        {
            string[] stringValues = { "Apple", "Banana", "Peach", "Mango" };
            FindMax<string> findMaxString = new FindMax<string>(stringValues);
            string actualMax = findMaxString.Maximum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringFourthPosition_whenFindMaxString_shouldReturnsFourthValue()
        {
            string[] stringValues = { "Apple", "Banana", "Mango", "Peach" };
            FindMax<string> findMaxString = new FindMax<string>(stringValues);
            string actualMax = findMaxString.Maximum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }
    }
}