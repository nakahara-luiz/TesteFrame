using NumbDecomposer.Domain;
using NumbDecomposer.Infra.DTO;
using NumbDecomposer.Infra.DTO.Builder;
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
    public DecompositionResultDTOBuilder _decompResultDTOBuilder { get; set; }
    
    public  DecomposerService()
    {
        _primeHelper = new PrimeGeneratorHelper();
        _divisorPopulateHelper = new DivisorStepPopulateHelper();
        _decompResultDTOBuilder = new DecompositionResultDTOBuilder();
    }

    public DecompositionResultDTO Decompose(int numb){
        DecompositionResult = new DecompositionResult(numb);

        const int decompositionObjective = 1;
        const int startDivisor = 1;
        const int minimalNumberValid = 2;

        var numberToDecompose = numb;
        if (numberToDecompose >= minimalNumberValid)
        
        {
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
        }
        
        return _decompResultDTOBuilder.Build(DecompositionResult);
    }
}