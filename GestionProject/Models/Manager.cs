using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Models
{
	public class Manager : BaseEntity
    {
       

        public string Managername { get; set; }

        public ICollection<TeamMember> teamMembers { get; set; }
        public ICollection<Project> Projects { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}


	

