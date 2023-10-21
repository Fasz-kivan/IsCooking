using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities
{
    public class Step
    {
        public int Id { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }

        public int Number { get; set; }

        public required string Descripton { get; set; }
    }
}