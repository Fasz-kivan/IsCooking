using Microsoft.Data.Sqlite;
using webapi.Dtos;
using webapi.Entities;

namespace webapi.Services
{
    public class RecipeService
    {
        private readonly List<Recipe>? recipes = new(); // store the db cache here

        public RecipeService(string connectionString = "Data source = isCooking.db") // todo inherit project db path
        {
            using SqliteConnection connection = new(connectionString);
            connection.Open();

            const string sql = "SELECT * FROM Recipe";

            var cmd = new SqliteCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            foreach (var item in reader)
            {
                Console.WriteLine(item.ToString());
            }

            //this.recipes = (List<Recipe>)cmd.ExecuteScalar(); // todo fill cache, how tf tho
            connection.Close();
        }

        public void SaveRecipe(Recipe recipe)
        {
            // todo save always goes to db and updates internal cache, avoid desync states
        }

        public Recipe? GetRecipeById(int id)
        {
            return null; // todo
        }

        public IReadOnlyCollection<RecipeDto>? GetAllRecipes()
        {
            if (this.recipes != null)
            { 
                IReadOnlyCollection<RecipeDto>? result = this.recipes.Select(x =>
                {
                    return new RecipeDto(x.Id, x.Name, x.Description, x.Difficulty, x.MinutesToMake, x.Ingredients, x.Steps, x.ImageRoute);
                }).ToList(); // todo maybe dont pass internal types in dto, make dto versions of step and ingredient too?

                return result;
            }

            //the pattern will be return empty list if not found for instance in filtered gets like getbyingredient
            return new List<RecipeDto>();
        }
    }
}
