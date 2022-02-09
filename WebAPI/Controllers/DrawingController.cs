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
        [HttpGet("{drawingID}")]
        public ActionResult<Drawing> GetDrawingByID(int drawingID)
        {
            Drawing drawing = _bl.GetDrawingByID(drawingID);

            if (drawing != null)
            {
                return Ok(drawing);
            }
            //Not found
            return NoContent();
                
        }
        // GET: api/<DrawingController>
        [HttpGet]
        public ActionResult<List<Drawing>> GetAllDrawings()
        {
            List<Drawing> allDrawings = _bl.GetAllDrawings();

            if (allDrawings != null)
            {
                return Ok(allDrawings);
            }
            //Not found
            return NoContent();
        }

        // GET: api/<DrawingController>
        [HttpGet("player/{playerID}")]
        public ActionResult<List<Drawing>> GetAllDrawingsByPlayerID(int playerID)
        {
            List<Drawing> allDrawings = _bl.GetAllDrawingsByPlayerID(playerID);

            if (allDrawings != null)
            {
                return Ok(allDrawings);
            }
            //Not found
            return NoContent();

        }
        // GET: api/<DrawingController>
        [HttpGet("wallpost/{wallpostID}")]
        public ActionResult<List<Drawing>> GetAllDrawingsByWallPostID(int wallpostID)
        {
            List<Drawing> allDrawings = _bl.GetAllDrawingsByWallPostID(wallpostID);

            if (allDrawings != null)
            {
                return Ok(allDrawings);
            }
            //Not found
            return NoContent();

        }

        // POST api/<DrawingController>
        [HttpPost]
        public ActionResult<Drawing> PostDrawing([FromBody] Drawing drawingToAdd)
        {   

            _bl.AddDrawing(drawingToAdd);
            return Ok(drawingToAdd);
        }
        // PUT api/<DrawingController>
        [HttpPut]
        public ActionResult<Drawing> UpdateDrawing([FromBody] Drawing drawingToUpdate)
        {
        
            _bl.UpdateDrawing(drawingToUpdate);
            return Ok(drawingToUpdate);
        }


        // DELETE api/<DrawingController>
        [HttpDelete("{drawingID}")]
        public ActionResult Delete(int drawingID)
        {
            _bl.DeleteDrawingByID(drawingID);
            return Ok();
        }
    }
}
