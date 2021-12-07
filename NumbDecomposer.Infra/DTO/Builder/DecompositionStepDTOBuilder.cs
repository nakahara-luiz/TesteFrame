using NumbDecomposer.Domain;

namespace NumbDecomposer.Infra.DTO.Builder
{
    public class DecompositionStepDTOBuilder
    {
        public IList<DecompositionStepDTO> BuildSteps(DecompositionResult result)
        {
            var steps = new List<DecompositionStepDTO>();

            var lenghtSteps = result.DivisorSteps.Count();

            for (int index = 0; index < lenghtSteps; index++)
            {
                if (index == 0)
                {
                    steps.Add(new DecompositionStepDTO
                    {
                        Divisors = result.DivisorSteps[index].Divisors
                    });
                }
                else 
                {
                    steps.Add(new DecompositionStepDTO
                    {
                        Divisors = result.DivisorSteps[index].Divisors,
                        Number = result.DecompositionSteps[index-1].Number,
                        PrimeFactor = new List<int>{ result.DecompositionSteps[index-1].PrimeDivisor }
                    });
                }
            }
            
            return steps;
        }
    }
}