using Microsoft.AspNetCore.Mvc;
using webapi.Dtos;
using webapi.Entities;
using webapi.NewFolder;

namespace webapi.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto>? GetAllRecipes()
        {
            return null;
        }

        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto> GetRecipeById([FromBody] int id)
        {
            return null;
        }

        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto>? GetRecipesByDifficulty([FromBody] Difficulty difficulty)
        {
            return null;
        }

        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto>? GetRecipesByIngredients([FromBody] IReadOnlyCollection<Ingredient> availableIngredients)
        {
            return null;
        }
    }
}
