namespace NumbDecomposer.Domain
{
    public class DivisorStep
    {
        public IList<int> Divisors { get; private set; }

        public DivisorStep()
        {
            Divisors = new List<int>();
        }

        public void AddDivisor(int divisor){
            Divisors.Add(divisor);
        }
    }
}