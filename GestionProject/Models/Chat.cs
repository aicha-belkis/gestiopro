using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Models
{
    public class Chat: BaseEntity

    {
     public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime when { get; set; }
       public string Img { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string ProjectId { get; set; }
        public Project project { get; set; }

       




    }
}