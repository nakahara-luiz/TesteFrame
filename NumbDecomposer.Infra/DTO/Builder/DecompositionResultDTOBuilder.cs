using NumbDecomposer.Domain;

namespace NumbDecomposer.Infra.DTO.Builder
{
    public class DecompositionResultDTOBuilder
    {
        private DecompositionStepDTOBuilder _decompStepBuilder;

        public DecompositionResultDTOBuilder()
        {
            _decompStepBuilder = new DecompositionStepDTOBuilder();    
        }

        public DecompositionResultDTO Build(DecompositionResult result)
        {
            return new DecompositionResultDTO
            {
                DecompositionResume = new DecompositionStepDTO
                {
                    Number = result.NumberToDecompose,
                    Divisors = result.DivisorSteps.SelectMany(d => d.Divisors).OrderBy(divisor => divisor).Distinct().ToList(),
                    PrimeFactor = result.DecompositionSteps.Select(stp => stp.PrimeDivisor).Distinct().ToList()
                },
                DecompositionSteps = _decompStepBuilder.BuildSteps(result)
            };
        }
    }
}