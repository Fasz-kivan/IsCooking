using webapi.Entities;
using webapi.Structure;

namespace webapi.Dtos
{
    public class RecipeDto
    {
        public RecipeDto(
            int id,
            string name,
            string? description,
            Difficulty difficulty,
            int minutesToMake,
            IReadOnlyCollection<Ingredient> ingredients,
            IReadOnlyCollection<Step> steps,
            string? imageRoute)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            Difficulty = difficulty;
            MinutesToMake = minutesToMake;
            Ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
            Steps = steps ?? throw new ArgumentNullException(nameof(steps));
            ImageRoute = imageRoute;
        }

        public int Id { get; }

        public string Name { get; }

        public string? Description { get; }

        public Difficulty Difficulty { get; }

        public int MinutesToMake { get; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; }

        public IReadOnlyCollection<Step> Steps { get; }

        public string? ImageRoute { get; }
    }
}
