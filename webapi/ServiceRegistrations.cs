using webapi.Services;

namespace webapi
{
    public class ServiceRegistrations
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton(typeof(RecipeProvider));
            //builder.Services.AddSingleton(typeof(IngredientProvider));
            //builder.Services.AddSingleton(typeof(StepProvider));
        }
    }
}
