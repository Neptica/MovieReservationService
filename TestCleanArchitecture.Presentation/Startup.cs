using Microsoft.EntityFrameworkCore;
using TestCleanArchitecture.Application.UseCases;
using TestCleanArchitecture.Domain.Contracts.Infrastructure;
using TestCleanArchitecture.Infrastructure;
using TestCleanArchitecture.Infrastructure.Persistence;
using Auth0.AspNetCore.Authentication.Api;
using Microsoft.AspNetCore.Authentication.JwtBearer;

public class Startup
{
    private readonly IConfiguration _configuration;
    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddHttpContextAccessor();
        services.AddTransient<UserService>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        services.AddCors(options =>
        {
            options.AddPolicy(name: "AllowSpecificOrigins", policy =>
            {
                policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
            });
        });

        services.AddAuth0ApiAuthentication(options =>
        {
            options.Domain = _configuration["Auth0:Domain"];
            options.JwtBearerOptions = new JwtBearerOptions
            {
                //Authority = _configuration["Auth0:Issuer"],
                Audience = _configuration["Auth0:Audience"]
            };
        });

        services.AddAuthorization(options =>
        {
            options.AddPolicy("read:epsteinfiles", policy => policy.RequireClaim("permissions", "read:epsteinfiles"));
            options.AddPolicy("read:unredactedfiles", policy => policy.RequireClaim("permissions", "read:unredactedfiles"));
        });

        //services.AddUseCaseCollection();
        //services.AddDataContextCollection();

        var connectionString = _configuration.GetConnectionString("DefaultString");
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }
}
