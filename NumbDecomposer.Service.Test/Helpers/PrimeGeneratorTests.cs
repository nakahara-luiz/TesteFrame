using NumbDecomposer.Service.Helpers;
using NUnit.Framework;

namespace NumbDecomposer.Service.Test.Helpers
{
    [TestFixture]
    public class PrimeGeneratorTests
    {
        private PrimeGeneratorHelper _primeGen;

        [SetUp]
        public void Setup()
        {
            _primeGen = new PrimeGeneratorHelper();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2CantBePrime(int number)
        {
            var result = _primeGen.IsPrime(number);

            Assert.IsFalse(result);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(13)]
        public void IsPrime_ShouldBePrime(int number)
        {
            var result = _primeGen.IsPrime(number);

            Assert.IsTrue(result);
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(6, 13)]
        public void GetPrime(int index, int expectedPrime)
        {
            var result = _primeGen.GetPrime(index);
            Assert.AreEqual(result, expectedPrime);

            var isPrime = _primeGen.IsPrime(result);
            Assert.IsTrue(isPrime);
        }

        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(11, 13)]
        public void GetNextPrime(int startSeek, int expectedPrime)
        {
            var result = _primeGen.GetNextPrime(startSeek);
            Assert.AreEqual(result, expectedPrime);

            var isPrime = _primeGen.IsPrime(result);
            Assert.IsTrue(isPrime);
        }
    }
}