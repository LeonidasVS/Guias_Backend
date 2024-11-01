using Backend.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IPostService _tittleService;

        public PostController (IPostService tittleService)
        {
            _tittleService = tittleService;
        }

        [HttpGet]

        public async Task<IEnumerable<PostDTO>>get()=>
            await _tittleService.get();
    }
}
