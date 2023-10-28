using Microsoft.AspNetCore.Mvc;
using webapi.Dtos;
using webapi.Entities;
using webapi.Services;
using webapi.Structure;

namespace webapi.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService ?? throw new ArgumentNullException(nameof(recipeService));
        }

        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto>? GetAllRecipes()
        {
            return _recipeService.GetAllRecipes();
        }

        [HttpGet]
        [Route("id")]
        public IReadOnlyCollection<RecipeDto>? GetRecipeById([FromBody] int id)
        {
            return null;
        }

        [HttpGet]
        [Route("difficulty")]
        public IReadOnlyCollection<RecipeDto>? GetRecipesByDifficulty([FromBody] Difficulty difficulty)
        {
            return null;
        }

        [HttpGet]
        [Route("ingredients")]
        public IReadOnlyCollection<RecipeDto>? GetRecipesByIngredients([FromBody] IReadOnlyCollection<IngredientDto> availableIngredients)
        {
            return null;
        }
    }
}
