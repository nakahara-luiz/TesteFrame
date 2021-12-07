using System.Collections.Generic;
using NumbDecomposer.Infra.DTO;

namespace NumbDecomposer.Service.Test.SampleMock
{
    public static class Decomposition45Mock
    {
        public static DecompositionResultDTO GetDecomposition()
        {
            return new DecompositionResultDTO
            {
                DecompositionResume = new DecompositionStepDTO
                {
                    Divisors = new List<int> { 1, 3, 5, 9, 15, 45 },
                    Number = 45,
                    PrimeFactor = new List<int> { 3, 5 }
                },
                DecompositionSteps = new List<DecompositionStepDTO>
                {
                    new DecompositionStepDTO
                    {
                        Divisors = new List<int> { 1 },
                        Number = 0,
                        PrimeFactor = new List<int>()
                    },
                    new DecompositionStepDTO
                    {
                        Divisors = new List<int> { 3 },
                        Number = 45,
                        PrimeFactor = new List<int> { 3 }
                    },
                    new DecompositionStepDTO
                    {
                        Divisors = new List<int> { 9 },
                        Number = 15,
                        PrimeFactor = new List<int> { 3 }
                    },
                    new DecompositionStepDTO
                    {
                        Divisors = new List<int> { 5, 15, 45 },
                        Number = 5,
                        PrimeFactor = new List<int> { 5 }
                    },
                }
            };
        }
    }
}