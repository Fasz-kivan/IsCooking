﻿using Microsoft.AspNetCore.Mvc;
using webapi.Dtos;
using webapi.Entities;
using webapi.Services;
using webapi.Stuff;

namespace webapi.Controllers
{
    public class RecipeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IReadOnlyCollection<RecipeDto>? GetAllRecipes()
        {
            var recipeService = new RecipeService();
            return recipeService.GetAllRecipes();
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
        public IReadOnlyCollection<RecipeDto>? GetRecipesByIngredients([FromBody] IReadOnlyCollection<Ingredient> availableIngredients)
        {
            return null;
        }
    }
}
