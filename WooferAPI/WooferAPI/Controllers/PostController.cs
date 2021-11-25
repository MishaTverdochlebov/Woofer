using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WooferAPI.Models;

namespace WooferAPI.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {

        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Post
            {

            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> Get(int id)
        {
            Post post = new Post(); // await context.Posts.FirstOrDefaultAsync();
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<Post>> Post(Post post)
        {
            // context.Posts.Add(post);
            // await context.SaveChangesAsync;
            return Ok(post);
        }

        [HttpPut]
        public async Task<ActionResult<Post>> Put(Post post)
        {
            // context.Update(post);
            // await context.SaveChangesAsync;
            return Ok(post);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Post>> Delete(int id)
        {
            Post post = new Post(); // await context.Posts.FirstOrDefaultAsync();
            if (post == null)
            {
                return NotFound();
            }
            // context.Remove(post);
            // await context.SaveChangesAsync;
            return Ok(post);
        }
    }
}
