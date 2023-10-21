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

        public int Id { get; set; }

        public int RecipeId { get; set; }

        public int Number { get; set; }

        public string Descripton { get; set; }
    }
}