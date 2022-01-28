using DL;
using BL;
using Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawingController : ControllerBase
    {
        private IBL _bl;
        public DrawingController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<DrawingController>
        [HttpGet("{id}")]
        public ActionResult<Drawing> GetDrawingByID(int DrawingID)
        {
            Drawing drawing = _bl.GetDrawingByID(DrawingID);

            if (drawing != null)
            {
                return Ok(drawing);
            }
            //Not found
            return NoContent();
                
        }

        // GET: api/<DrawingController>
        [HttpGet("{playerid}")]
        public ActionResult<List<Drawing>> GetAllDrawingsByUserID(int PlayerID)
        {
            List<Drawing> allDrawings = _bl.GetAllDrawingsByUserID(PlayerID);

            if (allDrawings != null)
            {
                return Ok(allDrawings);
            }
            //Not found
            return NoContent();

        }
        // GET: api/<DrawingController>
        [HttpGet("{wallpostid}")]
        public ActionResult<List<Drawing>> GetAllDrawingsByWallPostID(int WallPostID)
        {
            List<Drawing> allDrawings = _bl.GetAllDrawingsByWallPostID(WallPostID);

            if (allDrawings != null)
            {
                return Ok(allDrawings);
            }
            //Not found
            return NoContent();

        }

        // POST api/<DrawingController>
        [HttpPost]
        public ActionResult PostDrawing([FromBody] Drawing drawingToAdd)
        {
            _bl.AddDrawing(drawingToAdd);
            return Ok(drawingToAdd);
        }


        // DELETE api/<DrawingController>
        [HttpDelete("{id}")]
        public ActionResult Delete(int DrawingID)
        {
            _bl.DeleteDrawingByID(DrawingID);
            return Ok();
        }
    }
}
