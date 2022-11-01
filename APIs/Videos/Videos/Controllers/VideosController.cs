using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;
using Videos.Entidad;

namespace Videos.Controllers
{
    [ApiController]
    [Route("api/Videos")]
    public class VideosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VideosController(ApplicationDbContext context)
        {
            _context = context;
           
        }

        [HttpGet]
        public async Task<ActionResult<List<Video>>> Get()
        {
            return await _context.Videos.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult> Post(Video video)
        {
            _context.Add(video);
            await _context.SaveChangesAsync();
            return Ok();
            
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Video video, int id)
        {
            var existe = await _context.Videos.AnyAsync(x => x.id == id);

            if (!existe)
            {
                return NotFound();
            }

            if (video.id != id)
            {
                return BadRequest("El id del video no coincide con el id de la URL");
            }

            _context.Update(video);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await _context.Videos.AnyAsync(x=>x.id==id);

            if (!existe)
            {
                return NotFound();
            }
            _context.Remove(new Video() { id=id});
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
