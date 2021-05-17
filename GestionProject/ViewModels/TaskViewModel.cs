using GestionProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.ViewModels
{
	public class TeamMemberselect
	{
		public int TeamMemberId { get; set; }
		public string Group { get; set; }

	}
	public class TaskViewModel
	{
		public TaskViewModel()
		{
			TeamMemberlist = new List<SelectListItem>();
			TeamMemberId = new List<int>();
		}
		public List<SelectListItem> TeamMemberlist { get; set; }
		public string stringTeam { get; set; }
		public List<int> TeamMemberId { get; set; }


		public int TaskId { get; set; }
		public string NameTask { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime DueDate { get; set; }
		public string Teams { get; set; }



	}


		
}
