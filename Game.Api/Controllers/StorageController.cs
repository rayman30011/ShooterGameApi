using Game.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Game.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly GameContext _gameContext;

        public StorageController(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }


        [HttpGet("{id}/items")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var a = from stI in _gameContext.StorageInstances.Where(storage => storage.Id == id).Select(s => s.Items).FirstOrDefault()
                    join inst in _gameContext.ItemInstances on stI.InstId equals inst.Id
                    select new
                    {
                        stI.Pos,
                        Instance = inst,
                    };

            return Ok(a);
        }
    }
}
