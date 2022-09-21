using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Repositories
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly PortfolioContext _context;

        public ExperienceRepository(PortfolioContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Experience>> GetAsync()
        {
            return await _context.Experiences.Include(x=> x.Tags).ToListAsync();
        }
    }
}
