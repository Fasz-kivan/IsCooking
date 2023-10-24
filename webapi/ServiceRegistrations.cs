﻿using webapi.Services;

namespace webapi
{
    public class ServiceRegistrations
    {
        public ServiceRegistrations()
        {
        }

        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton(typeof(RecipeService));
            //builder.Services.AddSingleton(typeof(IngredientProvider));
            //builder.Services.AddSingleton(typeof(StepProvider));
        }
    }
}
