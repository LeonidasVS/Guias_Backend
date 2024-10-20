using Backend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private IRandomServices _singleto;
        private IRandomServices _rScope;
        private IRandomServices _rtransient;

        private IRandomServices _singleto2;
        private IRandomServices _rScope2;
        private IRandomServices _rtransient2;


        public RandomController(
            [FromKeyedServices("randomSingleton")] IRandomServices randomSingleton,
            [FromKeyedServices("randomScoped")] IRandomServices randomServicesScope,
            [FromKeyedServices("randomTransient")] IRandomServices randomTrasient,

            [FromKeyedServices("randomSingleton")] IRandomServices randomSingleton2,
            [FromKeyedServices("randomScoped")] IRandomServices randomServicesScope2,
            [FromKeyedServices("randomTransient")] IRandomServices randomTrasient2)
        {
            _singleto = randomSingleton;
            _rScope = randomServicesScope;
            _rtransient = randomTrasient;

            _singleto2 = randomSingleton2;
            _rScope2 = randomServicesScope2;
            _rtransient2 = randomTrasient2;

        }

        [HttpGet]
        public ActionResult<Dictionary<string, int>> Get()
        {
            var resultado = new Dictionary<string, int>();

            resultado.Add("Singleton 1", _singleto.Value);
            resultado.Add("Scope 1", _rScope.Value);
            resultado.Add("Transient 1", _rtransient.Value);

            resultado.Add("Singleton 2", _singleto2.Value);
            resultado.Add("Scope 2", _rScope2.Value);
            resultado.Add("Transient 2", _rtransient2.Value);

            return resultado;
        }
    }
}
