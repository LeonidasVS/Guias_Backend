using Backend.Controllers;

namespace Backend.Servicios
{
    public interface IPersonaServices
    {
        public bool validate(Persona personaValidar)
        {
            if (string.IsNullOrEmpty(personaValidar.name) || personaValidar.name.Length>10)
            {
                return false;
            }
            return true;
        }
        
    }
}
