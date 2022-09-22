﻿using Portfolio.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.ViewModels
{
    public class ExperienceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public ICollection<string> Tags { get; set; } = new List<string>();

    }
    public static class ExperienceViewModelMapper
    {
        public static ExperienceViewModel ToViewModel(this Experience experience)
        {
            return new ExperienceViewModel() { 
                Id = experience.Id,
                Name = experience.Name,
                Description = experience.Description,
                Tags = experience.Tags.Select(x=> x.Name).ToList()
            };
        }
    }
}