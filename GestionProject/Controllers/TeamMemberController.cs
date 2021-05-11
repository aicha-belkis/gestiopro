using GestionProject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Controllers
{
	public class TeamMemberController : Controller
	{
		private readonly AppDbContext _appDbContext;

		public TeamMemberController(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IActionResult Index()
		{
			var listofTeamMembers = _appDbContext.TeamMembers.ToList();
			return View(listofTeamMembers);
				
		}
	}
}