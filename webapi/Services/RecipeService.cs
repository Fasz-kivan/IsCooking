using webapi.Entities;

namespace webapi.Services
{
    public class RecipeService
    {
        private readonly List<Recipe> recipes = new(); // store the db cache here

        public RecipeService() 
        {
            // todo init, read db to memory
        }

        public void SaveRecipe(Recipe recipe)
        {
            // todo save always goes to db and updates internal cache, avoid desync states
        }

        public Recipe? GetRecipeById(int id)
        {
            return null; // todo
        }

        public IReadOnlyCollection<Recipe> GetAllRecipes()
        {
            return new List<Recipe>(); // todo, but the pattern will be return empty list if not found for instance in filtered gets like getbyingredient
        }
    }
}
