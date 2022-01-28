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
        [HttpGet("GetPlayersByAVGResult")]
        public List<Player> Get()
        {
            List<Player> rankedPlayersResult = _bl.GetPlayersByAVGResult;
            return rankedPlayersResult;
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerController>
        [HttpPost("CreateNewPlayer")]
        public void Post([FromBody] Player playerToAdd)
        {
            _bl.AddNewPlayerAccount;
            return Created("New Player Successfully Added", playerToAdd);
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
