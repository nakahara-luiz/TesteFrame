using Microsoft.AspNetCore.Mvc;
using NumbDecomposer.Infra.DTO;
using NumbDecomposer.Service;

namespace NumbDecomposer.API.Controllers
{
    [ApiController]
    [Route("api/decomposition")]
    public class DecompositionController: Controller
    {
        private DecomposerService _decomposer;

        public DecompositionController()
        {
            _decomposer = new DecomposerService();
        }

        /// <summary>
        /// Decompose a number systematically into prime factors
        /// </summary>
        /// <param name="number">Value to be decompose, must be ah integer</param>
        /// <returns>Decomposition by steps at 'DecompositionSteps'and resumed version at 'DecompositionResume'</returns>
        [HttpGet, Route("decompose/{number}")]
        public ActionResult<DecompositionResultDTO> Decompose(int number)
        {
            var result = _decomposer.Decompose(number);
            
            return Ok(result);
        }
    }
}