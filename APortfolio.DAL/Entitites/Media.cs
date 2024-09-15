using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Entitites
{
    public class Media
    {
        public int Id { get; set; }
        public string Url { get; set; } // URL to the media file
        public MediaType Type { get; set; } // Enum for MediaType 
        public int ProjectId { get; set; } 
        public virtual Project Project { get; set; } 
    }

    public enum MediaType
    {
        Image,
        Video,
        Document
    }
}
