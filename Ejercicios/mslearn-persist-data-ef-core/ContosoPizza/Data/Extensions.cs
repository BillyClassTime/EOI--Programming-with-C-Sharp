namespace ContosoPizza.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<PizzaContext>();
                if (context.Database.EnsureCreated())
                {
                    //bool Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade.EnsureCreated()
                    //Ensures that the database for the context exists.
                    //• If the database exists and has any tables, then no action is taken. Nothing is done to ensure the database schema is compatible with the Entity Framework model.
                    //• If the database exists but does not have any tables, then the Entity Framework model is used to create the database schema.
                }
                DbInitializer.Initialize(context); // No se vuelven a crear los datos si existieran
            }
        }
    }
}