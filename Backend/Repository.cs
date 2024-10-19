namespace Backend.Controllers
{
    public class Repository
    {
        public static List<Persona> personas = new List<Persona>{ 
         
           new Persona()
           {
               id=1,
               name="Juan Leonidas",
               age=20,
               email="JuanLeonidas@gmail.com"
           },
           new Persona()
           {
               id=2,
               name="Ever Sorto",
               age=28,
               email="EverSorto@gmail.com"
           },
           new Persona()
           {
               id=3,
               name="Jose Manuel",
               age=45,
               email="JManuel@gmail.com"
           }
        };
    }

    public class Persona
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
}
