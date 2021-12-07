namespace NumbDecomposer.Domain;
public class DecompositionResult
{
    private int _originalNumber;
    public int NumberToDecompose
    {
        get { return _originalNumber; }
        private set { _originalNumber = value; }
    }
    
    public IList<DivisorStep> DivisorSteps { get; private set; }

    public IList<DecompositionStep> DecompositionSteps { get; private set; }

    public DecompositionResult(int numberToDecomp)
    {
        NumberToDecompose = numberToDecomp;
        DivisorSteps = new List<DivisorStep>();
        DecompositionSteps = new List<DecompositionStep>();
    }

    public void AddDecompositionStep(int number, int primeDivisor)
    {
        DecompositionSteps.Add(new DecompositionStep(number, primeDivisor));
    }

    public void AddDivisorFindStep(DivisorStep step)
    {
        DivisorSteps.Add(step);
    }
}