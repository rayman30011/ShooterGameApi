using Game.DataAccess;
using Game.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Game.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemInstanceController : ControllerBase
    {
        private readonly GameContext _context;

        public ItemInstanceController(GameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Items.ToListAsync());
        }
    }
}
