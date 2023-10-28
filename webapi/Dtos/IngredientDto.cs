namespace webapi;

public class IngredientDto
{
    public IngredientDto(int id, string name, int count, string unit)
    {
        this.Id = id;
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.Count = count;
        this.Unit = unit ?? throw new ArgumentNullException(nameof(unit));
    }

    public int Id { get; }

    public string Name { get; }

    public int Count { get; }

    public string Unit { get; }
}
