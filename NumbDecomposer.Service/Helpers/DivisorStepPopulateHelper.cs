using NumbDecomposer.Domain;

namespace NumbDecomposer.Service.Helpers
{
    public class DivisorStepPopulateHelper
    {
        public void PopulateDivisors(DecompositionResult result)
        {
            var prevPrimeDivisor = 1;
            result.DivisorSteps.Add(FirstDivisorStep());

            foreach (var step in result.DecompositionSteps) 
            {
                var divisorFindStep = new DivisorStep();
                
                foreach (var prevDivisorStep in GetDivisorStep(prevPrimeDivisor, step, result.DivisorSteps))
                    foreach (var divisor in prevDivisorStep.Divisors)
                        divisorFindStep.AddDivisor(divisor * step.PrimeDivisor);
                
                prevPrimeDivisor = step.PrimeDivisor;

                result.DivisorSteps.Add(divisorFindStep);
            }
        }

        private DivisorStep FirstDivisorStep()
        {
            var firstStep= new DivisorStep();
            firstStep.AddDivisor(1);

            return firstStep;
        }

        private IList<DivisorStep> GetDivisorStep(int prevPrimeDivisor, DecompositionStep decompStep, IList<DivisorStep> divisorSteps)
        {
            return prevPrimeDivisor != decompStep.PrimeDivisor
                ? divisorSteps
                : new List<DivisorStep> { divisorSteps.Last() };
        }
    }
}