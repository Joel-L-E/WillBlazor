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
    public class AuthorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AuthorsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> Get()
        {
            return await context.Authors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> Get(int id)
        {
            var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
                return NotFound();
            return author;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Author author)
        {
            context.Add(author);
            await context.SaveChangesAsync();
            return author.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Author author)
        {
            context.Attach(author).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            context.Remove(author);
            await context.SaveChangesAsync();
            return NoContent();
        }








    }
}
