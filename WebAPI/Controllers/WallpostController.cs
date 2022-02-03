using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public ActionResult<List<WallPost>> GetAllWallPosts()
        {
            List<WallPost> allWallPosts = _bl.GetAllWallPosts();
            if (allWallPosts.Count != 0)
            {
                return Ok(allWallPosts);
            }
            return NoContent();
        }

        // GET: api/<WallpostController>
        [HttpGet("{id}")]
        public ActionResult<WallPost> GetWallpostByID(int id)
        {
            WallPost wallpost = _bl.GetWallpostByID(id);
            if (wallpost != null)
            {
                return Ok(wallpost);
            }
            return NoContent();
        }

        // GET api/<WallpostController>
        [HttpGet("category/{CategoryID}")]
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
        [HttpGet("search/{Keyword}")]
        public ActionResult<WallPost> GetWallpostByKeyword(string Keyword)
        {
            WallPost wallpost = _bl.GetWallpostByKeyword(Keyword);
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
            return Ok();
        }

        // DELETE api/<WallpostController>
        [HttpDelete("{id}")]
        public ActionResult Delete(int WallpostID)
        {
            _bl.DeleteWallpostByID(WallpostID);
            return Ok();
        }
    }
}