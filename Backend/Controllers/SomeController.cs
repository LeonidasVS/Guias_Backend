using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpGet("sync")]
        public IActionResult getSync()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Conexion Finalizada");

            Thread.Sleep(1000);
            Console.WriteLine("Conexion envio Finalizada");
            stopwatch.Stop();
            return Ok(stopwatch.Elapsed);
        }

        [HttpGet("async")]
        public async Task<IActionResult> GetAsync()
        {
            var tak1 = new Task(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea asincrona");
            });
            tak1.Start();
            Console.WriteLine("Finalizacion de la tarea NOAsincrona");
            await tak1;
            Console.WriteLine("Finalizacion de la tarea NOAsincrona Terminada");
            return Ok();
        }

        [HttpGet("async2")]
        public async Task<IActionResult> GetAsync2()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            var tak1 = new Task<int>(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea asincrona");
                return 8;
            });

            stopwatch.Start();
            var tak2 = new Task<int>(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Finalizacion de la tarea asincrona");
                return 1;
            });

            tak1.Start();
            tak2.Start();
            Console.WriteLine("Finalizacion de la tarea NOAsincrona");
            var resultado = await tak1;
            Console.WriteLine("Finalizacion de la tarea NOAsincrona Terminada");
            stopwatch.Stop();
            return Ok(resultado+ " "+ stopwatch.Elapsed);
        }
    }
}
