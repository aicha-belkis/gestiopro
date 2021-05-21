using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Models
{
	public class Manager : BaseEntity
    {
        public Manager()
        {
            Projects = new Collection<Project>();
        }


        public string ManagerName{ get; set; }

        public ICollection<TeamMember> TeamMembers { get; set; }
        public ICollection<Project> Projects { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}


	

