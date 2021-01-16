using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Server.Data;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Server.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class PostsController : ControllerBase
        {
            private readonly ApplicationDbContext context;

            public PostsController(ApplicationDbContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Post>>> Get()
            {
                return await context.Posts.ToListAsync();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Post>> Get(int id)
            {
                var post = await context.Posts.FirstOrDefaultAsync(x => x.Id == id);
                if (post == null)
                    return NotFound();
                return post;
            }

            [HttpPost]
            public async Task<ActionResult<int>> Post(Post post)
            {
                context.Add(post);
                await context.SaveChangesAsync();
                return post.Id;
            }

            [HttpPut]
            public async Task<ActionResult> Put(Post post)
            {
                context.Attach(post).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(int id)
            {
                var post = await context.Posts.FirstOrDefaultAsync(x => x.Id == id);
                if (post == null)
                {
                    return NotFound();
                }

                context.Remove(post);
                await context.SaveChangesAsync();
                return NoContent();
            }
        }
}

