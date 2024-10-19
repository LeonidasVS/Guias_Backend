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
        public decimal Get(decimal a, decimal c)
        {
            return a + c;   
        }

        [HttpPost]
        public decimal add(decimal a, decimal c)
        {
            return a - c;
        }

        [HttpPut]
        public decimal multiplicar(decimal a, decimal c)
        {
            return a * c;
        }

        [HttpDelete]
        public decimal Nmas1(decimal a, decimal c)
        {
            return a * (a * c);
        }
    }
}
