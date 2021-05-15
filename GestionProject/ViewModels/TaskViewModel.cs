using GestionProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.ViewModels
{
	public class TaskViewModel
	{
		public class TeamMemberSelectList
		{
			public int TeamMemberId { get; set; }
			public string Group { get; set; }

		}
		public int TaskId { get; set; }
		public string NameTask { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime DueDate { get; set; }
		public string Teams { get; set; }


		public IList<TeamMemberSelectList> TeamMembers{ get; set; }
		public int TeamMemberId { get; set; }
	}


		
}
