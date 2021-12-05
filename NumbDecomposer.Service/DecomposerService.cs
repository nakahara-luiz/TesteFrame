using NumbDecomposer.Domain;
using NumbDecomposer.Service.Helpers;

namespace NumbDecomposer.Service;
public class DecomposerService
{
    private int _numbToDecompose;
    public int NumberToDecompose
    {
        get { return _numbToDecompose; }
        private set { 
            _numbToDecompose = value;
            DecompositionResult = new DecompositionResult(value);
        }
    }
    
    private DecompositionResult _DecompResult;
    public DecompositionResult DecompositionResult
    {
        get { return _DecompResult; }
        private set { _DecompResult = value; }
    }

    private PrimeGeneratorHelper _primeHelper { get; set; }
    private DivisorStepPopulateHelper _divisorPopulateHelper { get; set; }
    private DecomposerService _instance;

    public  DecomposerService()
    {
        _primeHelper = new PrimeGeneratorHelper();
        _divisorPopulateHelper = new DivisorStepPopulateHelper();
    }

    public DecompositionResult Decompose(int numb){
        DecompositionResult = new DecompositionResult(numb);

        const int decompositionObjective = 1;
        const int startDivisor = 1;

        var numberToDecompose = numb;
        var decompositionFinish = false;
        var primeDivisor = _primeHelper.GetNextPrime(startDivisor);

        while(!decompositionFinish){
            if (numberToDecompose % primeDivisor == 0)
            {
                DecompositionResult.AddDecompositionStep(numberToDecompose, primeDivisor);

                numberToDecompose = numberToDecompose / primeDivisor;
            }
            else
                primeDivisor = _primeHelper.GetNextPrime(primeDivisor);

            if (numberToDecompose == decompositionObjective) 
                decompositionFinish = true;

            if (numberToDecompose < primeDivisor)
                primeDivisor = _primeHelper.GetNextPrime(startDivisor);
        }
        
        _divisorPopulateHelper.PopulateDivisors(DecompositionResult);

        return DecompositionResult;
    }
}