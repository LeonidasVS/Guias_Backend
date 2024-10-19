using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {
            return a + b;   
        }

        [HttpPost]
        public decimal add(Numbers c)
        {
            return c.A-c.B;
        }

        [HttpPut]
        public decimal multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpDelete]
        public decimal Nmas1(decimal a, decimal b)
        {
            return a * (a * b);
        }
    }
}
