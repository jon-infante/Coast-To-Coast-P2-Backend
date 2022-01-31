using Microsoft.AspNetCore.Mvc;
using BL;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private IBL _bl;

        public PlayerController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<UserController>
        [HttpGet("GetAllPlayers")]
        public List<Player> Get()
        {
            List<Player> allPlayers = _bl.GetAllPlayers();
            return allPlayers;
        }

        // GET: api/<UserController>
        [HttpGet("GetAllPlayersWithDrawings")]
        public async Task<List<Player>> GetAllPlayersWithDrawings()
        {
            List<Player> allPlayers = await _bl.GetAllPlayersWithDrawingsAsync();
            return allPlayers;
        }

        // GET api/<PlayerController>/5
        [HttpGet("GetPlayerByID/{id}")]
        public ActionResult<Player> Get(int PlayerID)
        {
            Player foundPlayer = _bl.GetPlayerByID(PlayerID);
            if(foundPlayer != null)
            {
                return Ok(foundPlayer);
            }
            else
            {
                return NoContent();
            }
        }

        // GET api/<PlayerController>/5
        [HttpGet("GetPlayerByIDWithDrawings/{id}")]
        public async Task<ActionResult<Player>> GetPlayerByIDWithDrawings(int PlayerID)
        {
            Player? foundPlayer = await _bl.GetPlayerByIDWithDrawingsAsync(PlayerID);
            if (foundPlayer != null)
            {
                return Ok(foundPlayer);
            }
            else
            {
                return NoContent();
            }
        }

        // POST api/<PlayerController>
        [HttpPost("CreateNewPlayer")]
        public ActionResult Post([FromBody] Player playerToAdd)
        {
            _bl.AddNewPlayerAccount(playerToAdd);
            return Created("New Player Successfully Added", playerToAdd);
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int PlayerID)
        {
            _bl.DeletePlayerByID(PlayerID);
            return Ok();
        }
    }
}
