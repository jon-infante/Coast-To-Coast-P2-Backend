using Microsoft.AspNetCore.Mvc;
using BL;
using Models;
using CustomExceptions;

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
        [HttpGet]
        public ActionResult<List<Player>> GetAllPlayers()
        {
            List<Player> allPlayers = _bl.GetAllPlayersWithDrawings();
            if (allPlayers.Count != 0)
            {
                return Ok(allPlayers);
            }
            return NoContent();
        }

        // GET api/<PlayerController>
        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayerByID(int id)
        {
            Player foundPlayer = _bl.GetPlayerByIDWithDrawings(id);
            if (foundPlayer != null)
            {
                return Ok(foundPlayer);
            }
            else
            {
                return NoContent();
            }
        }

        // GET api/<PlayerController>
        /*        [HttpGet("login/{username}")]
                public ActionResult GetLoginPlayer(string username, string password)
                {
                    Player currentPlayer = _bl.LoginPlayer(username, password);
                    if (currentPlayer.ID <= 0)
                    {
                        return BadRequest("User does not exist");
                    }
                    else
                    {
                        if (currentPlayer.Password == password)
                        {
                            return Ok("You've successfully logged in");
                        }
                        else
                        {
                            return BadRequest("Incorrect password");
                        }
                    }
                }*/

        //possible fix
       [HttpGet("login/{username}")]
        public ActionResult GetLoginPlayer(string username)
        {
            Player currentPlayer = _bl.LoginPlayer(username);
            if (currentPlayer == null)
            {
                Console.WriteLine("player doesn't exist, adding new player");
                Player playerToAdd = new Player();
                playerToAdd.Username = username;
                playerToAdd.Password = "";
                _bl.AddNewPlayerAccount(playerToAdd);
                return Created("Successfully added player: ", playerToAdd);
            }
            else
            {
                return Ok("player logged in");
            }



        }

        // POST api/<PlayerController>
        [HttpPost]
        public ActionResult PostPlayer([FromBody] Player playerToAdd)
        {
            try
            {
                _bl.AddNewPlayerAccount(playerToAdd);
                return Created("New Player Successfully Added", playerToAdd);
            }
            catch (DuplicateRecordException ex)
            {
                return Conflict(ex.Message);
            }
        }

        // DELETE api/<PlayerController>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bl.DeletePlayerByID(id);
            return Ok();
        }
    }
}
