using Portfolio.Core.ViewModels;

namespace Portfolio.Core.Services
{
    public interface IExperienceService
    {
        Task<List<ExperienceViewModel>> GetAsync();
    }
}