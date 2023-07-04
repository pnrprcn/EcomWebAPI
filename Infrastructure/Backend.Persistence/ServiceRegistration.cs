using Backend.Application.Abstraction;
using Backend.Persistence.Concretes;
using Backend.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Backend.Persistence {
    public static class ServiceRegistration 
    {
        public static void AddServices(this IServiceCollection services) 
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/Backend.API"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<PsqlDbContext>(options => options.UseNpgsql(configurationManager.GetConnectionString("Postgresql")));
            
        }
    }
}
