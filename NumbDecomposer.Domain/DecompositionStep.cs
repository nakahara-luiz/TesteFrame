namespace NumbDecomposer.Domain
{
    public class DecompositionStep
    {
        public int Number { get; private set; }
        public int PrimeDivisor { get; private set; }

        public DecompositionStep(int numb, int primeDivisor)
        {   
            Number = numb;
            PrimeDivisor = primeDivisor;
        }
    }
}