using FluentAssertions;
using NumbDecomposer.Infra.DTO;
using NumbDecomposer.Service.Test.SampleMock;
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

        [Test]
        public void Decompose45()
        {
            var expected = Decomposition45Mock.GetDecomposition();
            var result = _decompService.Decompose(45);

            ValidateDecompStructure(result, expected);
        }

        private void ValidateDecompStructure(DecompositionResultDTO result, DecompositionResultDTO expected)
        {
            result.DecompositionResume.Should().NotBeNull();
            result.DecompositionResume.Number.Should().Be(expected.DecompositionResume.Number);
            result.DecompositionResume.PrimeFactor.Should().Equal(expected.DecompositionResume.PrimeFactor);
            result.DecompositionResume.Divisors.Should().Equal(expected.DecompositionResume.Divisors);

            result.DecompositionSteps.Should().NotBeNull();
            result.DecompositionSteps.Count.Should().Be(expected.DecompositionSteps.Count);

            for (int i = 0; i < result.DecompositionSteps.Count; i++)
            {
                var step = result.DecompositionSteps[i];
                var expectedStep = expected.DecompositionSteps[i];

                step.Should().NotBeNull();
                step.Number.Should().Be(expectedStep.Number);
                step.PrimeFactor.Should().Equal(expectedStep.PrimeFactor);
                step.Divisors.Should().Equal(expectedStep.Divisors);
            }
        }
    }
}