using webapi.NewFolder;

namespace webapi.Entities
{
    public class Recipe
    {
        public Recipe(
            int id,
            string name,
            string? description,
            Difficulty difficulty,
            int minutesToMake,
            IReadOnlyCollection<Ingredient> ingredients,
            IReadOnlyCollection<Step> steps,
            string imageRoute)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            Difficulty = difficulty;
            MinutesToMake = minutesToMake;
            Ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
            Steps = steps ?? throw new ArgumentNullException(nameof(steps));
            ImageRoute = imageRoute ?? throw new ArgumentNullException(nameof(imageRoute));
        }

        public int Id { get; }

        public string Name { get; }

        public string? Description { get; }

        public Difficulty Difficulty { get; }

        public int MinutesToMake { get; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; }

        public IReadOnlyCollection<Step> Steps { get; }

        public string ImageRoute { get; }
    }
}
