using Microsoft.AspNetCore.Mvc;
using DL;
using BL;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallpostController : ControllerBase
    {
        private IBL _bl;
        public WallpostController(IBL bl)
        {
            _bl = bl;
        }
        
        // GET: api/<WallpostController>
        [HttpGet("{id}")]
        public ActionResult<WallPost> GetWallpostByID(int WallpostID)
        {
            WallPost wallpost = _bl.GetWallpostByID(WallpostID);
            if (wallpost != null)
            {
                return Ok(wallpost);
            }
            return NoContent();
        }

        // GET api/<WallpostController>
        [HttpGet("{categoryid}")]
        public ActionResult<List<WallPost>> GetAllWallpostByCategoryID(int CategoryID)
        {
            List<WallPost> allWallposts = _bl.GetAllWallpostByCategoryID(CategoryID);
            if (allWallposts != null)
            {
                return Ok(allWallposts);
            }
            return NoContent();
        }

        // GET api/<WallpostController>
        [HttpGet("{keyword}")]
        public ActionResult<List<WallPost>> GetWallpostByKeyword(string Key)
        {
            WallPost wallpost = _bl.GetWallpostByKeyword(Key);
            if (wallpost != null)
            {
                return Ok(wallpost);
            }
            return NoContent();
        }

        // POST api/<WallpostController>
        [HttpPost]
        public ActionResult PostWallpost([FromBody] WallPost wallpostToAdd)
        {
            _bl.AddWallpost(wallpostToAdd);
            return Ok(wallpostToAdd);
        }

        // DELETE api/<WallpostController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int WallpostID)
        {
            _bl.DeleteWallpostByID(WallpostID);
            return Ok();
        }
    }
}
