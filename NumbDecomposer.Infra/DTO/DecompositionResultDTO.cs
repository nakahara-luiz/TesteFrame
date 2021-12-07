namespace NumbDecomposer.Infra.DTO
{
    public class DecompositionResultDTO
    {
        public IList<DecompositionStepDTO> DecompositionSteps { get; set; }
        public DecompositionStepDTO DecompositionResume { get; set; }

        public DecompositionResultDTO()
        {
            DecompositionSteps = new List<DecompositionStepDTO>();
            DecompositionResume = new DecompositionStepDTO();
        }
    }
}