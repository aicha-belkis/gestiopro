using GestionProject.Data;
using GestionProject.Models;
using GestionProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProjectController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var model = new List<ProjectViewModel>();
            var projects = _appDbContext.Projects.Include(x => x.Client).ThenInclude(x => x.AppUser).ToList();

            foreach (var project in projects)
            {
                model.Add(new ProjectViewModel
                {
                    ClientNames = $"{project.Client.AppUser.Firstname} {project.Client.AppUser.Lastname}",
                    ProjectName = project.Projectname,
                    StartDate = project.CreationDate
                });
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ProjectViewModel model = new();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProjectViewModel model)
        {





            //Register project
            Project project = new()
            {
                Projectname = model.ProjectName,
                Projectmanager = model.ProjectManager,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Clientname = model.ClientNames,
                ProjectTeamMembers = model.Team
            };
                

            //Add project teams 
           project.TeamMember.Add(new Project
            {
                CreationDate = DateTime.Now,
               Projectname = model.ProjectName,
               Clientname = model.ClientNames,
               Projectmanager = model.ProjectManager

           });

            _appDbContext.Clients.Add(project);
            _appDbContext.SaveChanges();

            return RedirectToAction(nameof(Add));
        }
    }
}


