namespace webapi.Entities
{
    public class Step
    {
        public Step(int id, int recipeId, int number, string descripton)
        {
            Id = id;
            RecipeId = recipeId;
            Number = number;
            Descripton = descripton ?? throw new ArgumentNullException(nameof(descripton));
        }

        public int Id { get; }

        public int RecipeId { get; }

        public int Number { get; }

        public string Descripton { get; }
    }
}