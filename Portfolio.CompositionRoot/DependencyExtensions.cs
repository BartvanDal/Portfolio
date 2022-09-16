using Microsoft.Extensions.DependencyInjection;
using Portfolio.Core.Services;

namespace Portfolio.CompositionRoot
{
    public static class DependencyExtensions
    {
        public static void Inject(this IServiceCollection services)
        {
            services.AddSingleton<ITagService, TagService>();
        }

    }
}