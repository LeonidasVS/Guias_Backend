using Backend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private IPersonaServices _personaServices;

        public PersonaController([FromKeyedServices("personaServices")]IPersonaServices personaService)
        {
            _personaServices = personaService;
        }


        [HttpGet("all")]
        public List<Persona> GetPersonas() => Repository.personas;

        [HttpGet("{id}")]
        public ActionResult<Persona>Get(int id)
        {
            var persona = Repository.personas.FirstOrDefault(p => p.id == id);

            if (persona==null)
            {
                return NotFound();
            }
            return Ok(persona);
        }


        [HttpGet("search/{search}")]
        public List<Persona> Get(string search) => Repository.personas.Where(p => p.name.Contains(search.ToUpper())).ToList();

        [HttpPost]
        public IActionResult Add(Persona people)
        {
            if (!_personaServices.validate(people))
            {
                return BadRequest();
            }
            Repository.personas.Add(people);
            return NoContent();
        }

    }
}
