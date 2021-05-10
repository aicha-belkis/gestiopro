using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static GestionProject.Models.Tasks;

namespace GestionProject.Models
{
	public class Tasks : BaseEntity {

		public Tasks()

		{
		ProjectTeamMembers = new Collection<TeamMemberProject>();
         }


	 
		public string NameTask { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime DueDate{ get; set; }
		public string Group { get; set; }


		public int MangerId { get; set; }
		public Manager Manager { get; set; }

		public int ProjectId { get; set; }
		public Project Project { get; set; }

		public ICollection<TeamMemberProject> ProjectTeamMembers { get; set; }
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }

	}
}



