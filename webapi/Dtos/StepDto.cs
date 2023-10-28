namespace webapi;

public class StepDto
{
    public StepDto(int id, int recipeId, int number, string descripton)
    {
        this.Id = id;
        this.RecipeId = recipeId;
        this.Number = number;
        this.Descripton = descripton ?? throw new ArgumentNullException(nameof(descripton));
    }

    public int Id { get; }

    public int RecipeId { get; }

    public int Number { get; }

    public string Descripton { get; }
}
