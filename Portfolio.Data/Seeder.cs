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
            modelBuilder.Entity<Tag>().HasData(
               new Tag { Id = 1, Name = "C#", YearStarted = 2017 },
               new Tag { Id = 2, Name = "HTML5", YearStarted = 2016 },
               new Tag { Id = 3, Name = "CSS3", YearStarted = 2016 },
               new Tag { Id = 4, Name = ".Net", YearStarted = 2017 },
               new Tag { Id = 5, Name = ".Net Core", YearStarted = 2019 },
               new Tag { Id = 6, Name = "Angular", YearStarted = 2021 },
               new Tag { Id = 7, Name = "Blazor", YearStarted = 2022 });

            modelBuilder.Entity<Experience>().HasData(
                new Experience { Id = 1, Name = "Goudkoorts //als dat werkt", StartedAt = new DateTime(2018, 06, 01), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                new Experience { Id = 2, Name = "Portfolio" }
                );


            modelBuilder.Entity<Experience>()
            .HasMany(e => e.Tags)
            .WithMany(t => t.Experiences)
            .UsingEntity(j =>
                j.HasData(
                    new { ExperiencesId = 1, TagsId = 1 },
                    new { ExperiencesId = 1, TagsId = 4 },
                    new { ExperiencesId = 1, TagsId = 5 },
                    new { ExperiencesId = 2, TagsId = 1 },
                    new { ExperiencesId = 2, TagsId = 5 },
                    new { ExperiencesId = 2, TagsId = 7 }
                    )
                );


        }
    }
}
