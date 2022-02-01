using BL;
using Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {

        private IBL _bl;

        public LikeController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<LikeController>
        [HttpGet("{likeID}")]
        public ActionResult<Like> GetLikeByID(int likeID)
        {
            Like like = _bl.GetLikeByID(likeID);
            if (like != null)
            {
                return Ok(like);
            }
            return NoContent();
        }

        // GET api/<LikeController>
        [HttpGet("player/{playerID}")]
        public ActionResult<List<Like>> GetLikesByPlayerID(int playerID)
        {
            List<Like> allPlayerLikes = _bl.GetLikesByPlayerID(playerID);
            if (allPlayerLikes.Count != 0)
            {
                return Ok(allPlayerLikes);
            }
            return NoContent();
        }
        // GET api/<LikeController>
        [HttpGet("drawing/{drawingID}")]
        public ActionResult<List<Like>> GetLikesByDrawingID(int drawingID)
        {
            List<Like> allDrawingLikes = _bl.GetLikesByDrawingID(drawingID);
            if (allDrawingLikes.Count != 0)
            {
                return Ok(allDrawingLikes);
            }
            return NoContent();
        }
        // GET api/<LikeController>
        [HttpGet("comment/{commentID}")]
        public ActionResult<List<Like>> GetLikesByCommentID(int commentID)
        {
            List<Like> allCommentLikes = _bl.GetLikesByPlayerID(commentID);
            if (allCommentLikes.Count != 0)
            {
                return Ok(allCommentLikes);
            }
            return NoContent();
        }
        // POST api/<LikeController>
        [HttpPost]
        public ActionResult PostLike([FromBody] Like likeToAdd)
        {
            _bl.AddLike(likeToAdd);
            return Ok();
        }

        // DELETE api/<LikeController>
        [HttpDelete("{likeID}")]
        public ActionResult DeleteLike(int likeID)
        {
            Like like = _bl.GetLikeByID(likeID);
            if(like != null)
            {
                _bl.DeleteLikeByID(likeID);
                return Ok();
            }
            return NoContent();
        }
    }
}
