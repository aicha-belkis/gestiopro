using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int ProjectId { get; set; }
        public Project project { get; set; }

        public int DocumentId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string FileType { get; set; }
        [MaxLength]
        public byte[] DataFiles { get; set; }
        


        public int TeamMemberId { get; set; }
        public TeamMember teamMember{ get; set; }





    }
}