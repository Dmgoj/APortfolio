using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public string? Bio { get; set; }
        public string? Address { get; set; }
      //  public string? Image { get; set; }
        public virtual ICollection<Portfolio> Portfolios { get; set; }
       
       [Display(Name = "User")]
        public string Username => $"{FirstName} {LastName}";
    }
}
