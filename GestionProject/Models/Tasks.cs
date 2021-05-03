using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static GestionProject.Models.Tasks;

namespace GestionProject.Models
{
	public class Tasks

	{
		public string Nametask { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime duedate{ get; set; }

		

		public ICollection<TeamMemberProject> ProjectTeamMembers { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }

	}
}



