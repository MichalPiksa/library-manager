using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Marten;

namespace LibraryManager.DAL;

public class DALInstaller
{
    private readonly IConfiguration _configuration;

    public DALInstaller(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void Configure(IServiceCollection services)
    {
        services.AddMarten(options =>
        {
            options.Connection(_configuration.GetConnectionString("LibraryManagerDefault"));
        });
        services.AddScoped<IUserService, UserService>();
    }
}