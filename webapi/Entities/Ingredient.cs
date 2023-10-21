namespace webapi.Entities
{
    public class Ingredient
    {
        public Ingredient(int id, string name, int count, string unit)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Count = count;
            Unit = unit ?? throw new ArgumentNullException(nameof(unit));
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public string Unit { get; set; }
    }
}
