namespace Services;

public static class ModuleServicesDependencies
{
    public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
    {

        //Configuration of AutoMapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //Add Fluent Validation
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
