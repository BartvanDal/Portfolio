using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Services;
using Portfolio.Data;

namespace Portfolio.CompositionRoot
{
    public static class DependencyExtensions
    {
        public static void Inject(this IServiceCollection services)
        {
            services.AddSingleton<ITagService, TagService>();
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