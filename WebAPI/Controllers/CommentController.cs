using DL;
using BL;
using Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private IBL _bl;

        public CommentController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<CommentController>
        [HttpGet("commentID")]
        public ActionResult<Comment> GetCommentByID(int commentID)
        {
            Comment comment = _bl.GetCommentByID(commentID);
            if(comment != null)
            {
                return Ok(comment);
            }
            return NoContent();
        }

        // GET api/<CommentController>
        [HttpGet("drawing/{drawingID}")]
        public ActionResult<List<Comment>> GetCommentByDrawingID(int drawingID)
        {
            List<Comment> selectedComments = _bl.GetCommentsByDrawingID(drawingID);
            if (selectedComments != null)
            {
                return Ok(selectedComments);
            }
            return NoContent();
        }

        // POST api/<CommentController>
        [HttpPost]
        public ActionResult PostComment([FromBody] Comment comToAdd)
        {
            _bl.AddComment(comToAdd);
            return Ok();
        }

        // PUT api/<CommentController>
        [HttpPut("comment/{commentID}")]
        public ActionResult<Comment> EditCommentByID(int commentID, string message)
        {
            Comment selectedComment = _bl.GetCommentByID(commentID);
            if(selectedComment != null)
            {
                _bl.EditCommentByID(commentID, message);
                selectedComment.Message = message;
                return Ok(selectedComment);
            }
            return NoContent();
        }

        // DELETE api/<CommentController>
        [HttpDelete("{commentID}")]
        public ActionResult DeleteComment(int commentID)
        {
            Comment selectedComment = _bl.GetCommentByID(commentID);
            if (selectedComment != null)
            {
                _bl.DeleteCommentByID(commentID);
                return Ok();
            }
            return NoContent();
        }
    }
}
