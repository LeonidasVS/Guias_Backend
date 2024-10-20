using Backend.Controllers;

namespace Backend.Servicios
{
    public class PersonaService2 : IPersonaServices
    {
        public bool validate(Persona personaValidar)
        {
            if (string.IsNullOrEmpty(personaValidar.name) || personaValidar.name.Length >100  || personaValidar.name.Length<3)
            {
                return false;
            }
            return true;
        }

    }
}
