using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WillBlazor.Server.Data;
using WillBlazor.Server.Helpers;
using WillBlazor.Shared.Entities;

namespace WillBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PicturesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PicturesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Picture>>> Get()
        {
            return await context.Pictures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Picture>> Get(int id)
        {
            var picture = await context.Pictures.FirstOrDefaultAsync(x => x.Id == id);
            if (picture == null)
                return NotFound();
            return picture;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Picture picture)
        {
            context.Add(picture);
            await context.SaveChangesAsync();
            return picture.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Picture picture)
        {
            context.Attach(picture).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var picture = await context.Pictures.FirstOrDefaultAsync(x => x.Id == id);
            if (picture == null)
            {
                return NotFound();
            }

            context.Remove(picture);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}