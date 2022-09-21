using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Portfolio.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class PortfolioContext : DbContext
    {
        DbSet<Tag> Tags { get; set; }
        DbSet<Experience> Experiences { get; set; }

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();

            modelBuilder.Entity<Experience>()
                .HasMany(e => e.Tags)
                .WithMany(t => t.Experiences)
                .UsingEntity(j =>
                    j.HasData(
                        new { ExperiencesId = 1, TagsId = 1 }
                        )
                    );
            base.OnModelCreating(modelBuilder);
        }
    }
}
