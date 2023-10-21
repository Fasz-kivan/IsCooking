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
            string imageRoute)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            Difficulty = difficulty;
            MinutesToMake = minutesToMake;
            ImageRoute = imageRoute ?? throw new ArgumentNullException(nameof(imageRoute));
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public Difficulty Difficulty { get; set; }

        public int MinutesToMake { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        public IReadOnlyCollection<Step> Steps { get; set; }

        public string ImageRoute { get; set; }
    }
}
