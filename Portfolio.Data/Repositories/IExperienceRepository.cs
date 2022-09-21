using Portfolio.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experience>> GetAsync();
    }
}
