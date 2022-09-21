using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var Tag1 = new Tag { Id = 1, Name = "C#", YearStarted = 2018 };
            var Experience1 = new Experience { Id = 1, Name = "AniMedic", StartedAt = new DateTime(2018, 06, 01) };


            modelBuilder.Entity<Tag>().HasData(Tag1);

            modelBuilder.Entity<Experience>().HasData(Experience1);

        }
    }
}
