using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Entities
{
    [PrimaryKey(nameof(MediaId), nameof(UserId))]
    public class LikeDislike
    {
        public int MediaId { get; set; }
        public string UserId { get; set; }
        public bool IsLike { get; set; }
        [ForeignKey ("MediaId")]
        public virtual Media Media { get; set; }
        [ForeignKey ("UserId")]
        public virtual AppUser User { get; set; }

    }
}
