using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
               new Tag { Id = 1, Name = "C#", YearStarted = 2017, Type = TagType.Language },
               new Tag { Id = 2, Name = "HTML5", YearStarted = 2016, Type = TagType.Language },
               new Tag { Id = 3, Name = "CSS3", YearStarted = 2016, Type = TagType.Language }, 
               new Tag { Id = 4, Name = "Typescript", YearStarted = 2021, Type = TagType.Language }, 
               new Tag { Id = 5, Name = ".Net Framework", YearStarted = 2017, Type = TagType.Framework },
               new Tag { Id = 6, Name = ".Net Core", YearStarted = 2019, Type = TagType.Framework },
               new Tag { Id = 7, Name = "Angular", YearStarted = 2021, Type = TagType.Framework },
               new Tag { Id = 8, Name = "Blazor", YearStarted = 2022, Type = TagType.Framework },
               new Tag { Id = 9, Name = "ASP .Net Core", YearStarted = 2019, Type = TagType.Framework },
               new Tag { Id = 10, Name = "RESTful APIs", YearStarted = 2021 },
               new Tag { Id = 11, Name = "Bootstrap", YearStarted = 2017, Type = TagType.Framework },
               new Tag { Id = 12, Name = "Visual Studio", YearStarted = 2015, Type = TagType.Tool },
               new Tag { Id = 13, Name = "Visual Studio Code", YearStarted = 2017, Type = TagType.Tool },
               new Tag { Id = 14, Name = "Nuget", YearStarted = 2015, Type = TagType.Tool },
               new Tag { Id = 15, Name = "Entity Framework", YearStarted = 2019, Type = TagType.Tool },
               new Tag { Id = 16, Name = "npm", YearStarted = 2020, Type = TagType.Tool });

            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    Name = "Basisopleiding Sogeti",
                    Description = "Binnen Sogeti heb ik een specialisatieopleiding gevolgd. Hier heb ik gewerkt aan de backend van een onboardingsapp voor nieuwe medewerkers. Het doel van de onboardingsapp is een takenlijst en algemene informatie tonen zodat nieuwe medewerkers weten wat van hen wordt verwacht en waar ze informatie kunnen vinden.\r\n\r\nIn dit project was ik verantwoordelijk voor het opzetten van een Restful API gemaakt in ASP .Net Core welke geconsumeerd werden door een React Native mobiele app en een Angular dashboard applicatie. Daarnaast heb ik gewerkt aan de frontend van het Angular dashboard.\r\n",
                    StartedAt = new DateTime(2022, 8, 1),
                    ImageName = "c1bf47f0ecce9864a6d5e4651ef11782.jpg"
                }
                );

            modelBuilder.Entity<Experience>()
            .HasMany(e => e.Tags)
            .WithMany(t => t.Experiences)
            .UsingEntity(j =>
                j.HasData(
                    new { ExperiencesId = 1, TagsId = 1 },
                    new { ExperiencesId = 1, TagsId = 2 },
                    new { ExperiencesId = 1, TagsId = 3 },
                    new { ExperiencesId = 1, TagsId = 4 },
                    new { ExperiencesId = 1, TagsId = 6 },
                    new { ExperiencesId = 1, TagsId = 7 },
                    new { ExperiencesId = 1, TagsId = 9 },
                    new { ExperiencesId = 1, TagsId = 10 },
                    new { ExperiencesId = 1, TagsId = 11 },
                    new { ExperiencesId = 1, TagsId = 12 },
                    new { ExperiencesId = 1, TagsId = 13 },
                    new { ExperiencesId = 1, TagsId = 14 },
                    new { ExperiencesId = 1, TagsId = 15 },
                    new { ExperiencesId = 1, TagsId = 16 }
                    )
                );
        }
    }
}
