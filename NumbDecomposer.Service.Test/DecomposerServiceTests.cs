using NUnit.Framework;

namespace NumbDecomposer.Service.Test
{
    [TestFixture]
    public class DecomposerServiceTests
    {
        private DecomposerService _decompService;

        [SetUp]
        public void Setup()
        {
            _decompService = new DecomposerService();
        }

        [TestCase(45)]
        public void x(int numberToDecompose)
        {
            var result = _decompService.Decompose(numberToDecompose);
        }
    }
}