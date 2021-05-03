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

		public string Nametask { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime duedate { get; set; }

		public enum TypesOfJob
		{
			Webdeveloper,
			Softwaretester,
			Databaseadministrator,
			Networkarchitect,
			designe
		}


		public class JObType
		{
			public int Id { get; set; }
			public TypesOfJob types { get; set; }
		}
	}
}
