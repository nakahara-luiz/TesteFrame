namespace NumbDecomposer.Infra.DTO
{
    public class DecompositionStepDTO
    {
        public int Number { get; set; }
        public IList<int> PrimeFactor { get; set; }
        public IList<int> Divisors { get; set; }

        public DecompositionStepDTO()
        {
            PrimeFactor = new List<int>();
            Divisors = new List<int>();
        }
    }
}