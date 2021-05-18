using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Models
{
    [Table("Files")]
    public class Chat: BaseEntity

    {
     public string UserName { get; set; }
       

        public DateTime when { get; set; }
       public string Img { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string ProjectId { get; set; }
        public Project project { get; set; }



        public string TeamMemberId { get; set; }
        public TeamMember teamMember{ get; set; }





    }
}