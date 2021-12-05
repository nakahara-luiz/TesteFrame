namespace NumbDecomposer.Service.Helpers
{
    public class PrimeGeneratorHelper
    {
        private const int NEXTINDEX = 1;

        public bool IsPrime(int numb){
            if (numb < 2) return false;
            
            var limitDivisor = numb / 2;
            
            for (int i = 2; i <= limitDivisor; i++)
                if (numb % i == 0)
                    return false;
            
            return true;
        }

        public int GetPrime(int index, int startFind = 1) {
            var gotPrime = false;

            while(!gotPrime){
                startFind++;
                if (IsPrime(startFind))
                    index--;

                if (index.Equals(0))
                    return startFind;
            }

            return 0;
        }

        public int GetNextPrime(int startFind){
            return GetPrime(NEXTINDEX, startFind);
        }
    }
}