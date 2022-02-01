using DL;
using BL;
using Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IBL _bl;
        public CategoryController(IBL bl)
        {
            _bl = bl;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public ActionResult<List<Category>> GetAllCategories()
        {
            List<Category> allCategories = _bl.GetAllCategories();
            if(allCategories.Count != 0)
            {
                return Ok(allCategories);
            }
            return NoContent();
        }

        // GET api/<CategoryController>/
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategoryByID(int id)
        {
            Category category = _bl.GetCategoryByID(id);
            if (category != null)
            {
                return Ok(category);
            }
            return NoContent();
        }

        // POST api/<CategoryController>
        [HttpPost]
        public ActionResult Post([FromBody] Category catToAdd)
        {
            _bl.AddCategory(catToAdd);
            return Ok();
        }
        // GET api/<CategoryController>/
        [HttpGet("search/{searchTerm}")]
        public ActionResult<List<Category>> GetCategoriesBySearchTerm(string searchTerm)
        {
            List<Category> selectedCategories = _bl.SearchCategories(searchTerm);
            if (selectedCategories.Count != 0)
            {
                return Ok(selectedCategories);
            }
            return NoContent();
        }

        // DELETE api/<CategoryController>/
        [HttpDelete("{categoryID}")]
        public ActionResult DeleteCategory(int categoryID)
        {
            _bl.DeleteCategory(categoryID);
            return Ok();          
        }
    }
}
