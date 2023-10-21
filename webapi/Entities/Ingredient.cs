namespace webapi.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int Count { get; set; }

        public required string Unit { get; set; }
    }
}
