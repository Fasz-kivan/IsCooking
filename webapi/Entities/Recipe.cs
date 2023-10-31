using webapi.Structure;

namespace webapi.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public Difficulty Difficulty { get; set; }

        public int MinutesToMake { get; set; }

        public required IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        public required IReadOnlyCollection<Step> Steps { get; set; }

        public string? ImageRoute { get; set; }
    }
}
