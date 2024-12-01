using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public string? Image { get; set; } = "/images/projects/default.jpeg";
        [Display(Name = "Creation Date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy.}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } 
        public virtual ICollection<Project>? Projects { get; set; }
        public string? UserId { get; set; } 
        public virtual AppUser? User { get; set; } 
    }
}
