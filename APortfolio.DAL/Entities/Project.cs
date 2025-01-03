﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Entities
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageUrl { get; set; } = "/images/projects/default.jpeg";// URL for project image
        public ICollection<Media>? Media { get; set; }
        public int PortfolioId { get; set; } 
        public virtual Portfolio Portfolio { get; set; } 
    }
}
