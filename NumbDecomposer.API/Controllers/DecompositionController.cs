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

        [HttpGet, Route("decompose/{number}")]
        public ActionResult<DecompositionResultDTO> Decompose(int number)
        {
            var result = _decomposer.Decompose(number);
            
            return Ok(result);
        }
    }
}