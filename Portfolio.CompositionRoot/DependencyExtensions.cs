using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Services;
using Portfolio.Data;
using Portfolio.Data.Repositories;

namespace Portfolio.CompositionRoot
{
    public static class DependencyExtensions
    {
        public static void Inject(this IServiceCollection services)
        {
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<IExperienceService, ExperienceService>();


            services.AddTransient<IExperienceRepository, ExperienceRepository>();
        }

        public static void AddDataContext(this IServiceCollection services)
        {
            services.AddDbContext<PortfolioContext>(x =>
            {
                x.UseSqlite("Data Source = Portfolio.db");
            });
        }
    }
}