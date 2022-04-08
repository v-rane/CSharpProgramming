using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticePrograms;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrimeNumber()
        {
            CheckPrime checkPrime = new CheckPrime();
            Assert.AreEqual(true, checkPrime.isPrime(7));
        }
        public void TestCheckAnagram()
        {
            CheckAnagram checkAnagram = new CheckAnagram();
            Assert.AreEqual(false, checkAnagram.areAnagram("Shital","sakshi"));

        }
        public void TestTwoSum()
        {
            TwoSum twoSum = new TwoSum();
            int[] array= {2,3,4,5,8};
            Assert.AreEqual(true, twoSum.getTwoSum(array, 5,5));
        }
        public void TestSumOfNumber()
        {
            SumOfNumber sumOfNumber = new SumOfNumber();
            Assert.AreEqual(4, sumOfNumber.getSum(3));
        }
        public void TestEvenOdd()
        {
            CheckEven checkEven = new CheckEven();
            Assert.AreEqual(true, checkEven.getEven(4));
        }

    }
}
