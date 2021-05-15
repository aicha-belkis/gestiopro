
using GestionProject.Data;
using GestionProject.Models;
using GestionProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                    ClientName = $"{project.Client.AppUser.Firstname} {project.Client.AppUser.Lastname}",
                    ProjectName = project.ProjectName,
                    StartDate = project.CreationDate,
                    ManagerName = project.ProjectManager
                });
            }

            return View(model);






        }


        [HttpGet]
        public IActionResult Add()
        {
            ProjectViewModel model = new();
            model.Clients = new List<ClientSelectList>();
            var clients = _appDbContext.Clients.ToList();
            foreach (var client in clients)
            {
                model.Clients.Add(new ClientSelectList()
                {
                    ClientId = client.Id,
                    ClientNames = client.ClientName
                });
            }

            return View(model);


            ManagerViewModel vm = new();
            var Managers = _appDbContext.Managers.ToList();
            foreach (var Manager in Managers)
            {
                model.Managers.Add(new ManagerSelectList()
                {
                    ManagerId = Manager.Id,
                    ManagerName = Manager.ManagerName,
                });
            }


            return View(vm);


            List<TeamMemberlist> TeamMembers = new List<TeamMemberlist>
            {

                new  TeamMemberlist { TeamMemberId=1, Group= "API" },
                new  TeamMemberlist { TeamMemberId=2, Group= "UI" },
                 new  TeamMemberlist { TeamMemberId=3, Group= "BIG DATA" },



            };
            List<TeamMemberlist> SelectedTeamMembers = new List<TeamMemberlist>
            {
                 new  TeamMemberlist { TeamMemberId=1, Group= "API" },
                new  TeamMemberlist { TeamMemberId=2, Group= "UI" }

            };
            var DetailsModel = new ProjectViewModel();
            DetailsModel.TeamMemberId = SelectedTeamMembers.Select(x => x.Id).ToList();
            DetailsModel.TeamMemberlist = TeamMembers.ToList().ConvertAll(k =>
            {
                return new SelectListItem()
                {
                    Value = k.TeamMemberId.ToString(),
                    Text = k.Group
                };
            });
            return View(DetailsModel);

        }

      


        [HttpPost]
        public async Task<IActionResult> Add(ProjectViewModel model)
        {


            var project = new Project()
            {

                ProjectName = model.ProjectName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
               
                ClientId = model.ClientId,
                MangerId = model.ManagerId
                
            };

             _appDbContext.Projects.Add(project);
            _appDbContext.SaveChanges();

            return RedirectToAction(nameof(Add));
        }

        }
    }



