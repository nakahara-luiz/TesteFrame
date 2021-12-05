using NumbDecomposer.Domain;

namespace NumbDecomposer.Service.Helpers
{
    public class DivisorStepPopulateHelper
    {
        public void PopulateDivisors(DecompositionResult result)
        {
            var prevPrimeDecomposer = 1;
            result.DivisorSteps.Add(FirstDivisorStep());

            foreach (var step in result.DecompositionSteps) 
            {
                var divisorFindStep = new DivisorStep();
                
                foreach (var prevDivisorStep in GetDivisorStep(prevPrimeDecomposer, step, result.DivisorSteps))
                    foreach (var divisor in prevDivisorStep.Divisors)
                        divisorFindStep.AddDivisor(divisor * step.PrimeDivisor);
                
                prevPrimeDecomposer = step.PrimeDivisor;

                result.DivisorSteps.Add(divisorFindStep);
            }
        }

        private DivisorStep FirstDivisorStep()
        {
            var firstStep= new DivisorStep();
            firstStep.AddDivisor(1);

            return firstStep;
        }

        private IList<DivisorStep> GetDivisorStep(int prevPrimeDecomposer, DecompositionStep step, IList<DivisorStep> divisorSteps)
        {
            return prevPrimeDecomposer != step.PrimeDivisor
                ? divisorSteps
                : new List<DivisorStep> { divisorSteps.Last() };
        }
    }
}