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
    public class TasksController : Controller

    {

        private readonly AppDbContext _appDbContext;

        public TasksController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index(
            )
        {

            var model = new List<TaskViewModel>();
            var tasks = _appDbContext.Tasks.Include(x => x.ProjectTeamMembers ).ToList();
            foreach (var task in tasks)
            {
                model.Add(new TaskViewModel
                {

                    NameTask = task.NameTask,
                    DueDate = task.DueDate,
                    Teams = $"{task.ProjectTeamMembers} ",

                });

            }
            return View(model);

            TeamMemberViewModel vm = new();
            var TeamMembers = _appDbContext.TeamMembers.ToList();
            foreach (var TeamMember in TeamMembers)
            {
                vm.TeamMembers.Index(new TeamMemberSelectList()
                {
                    TeamMemberId = TeamMember.Id,
                    Group = TeamMember.Group,
                });
            }

            return View(vm);

        }

        [HttpPost]
        public async Task<IActionResult> Index(TaskViewModel model)
        { 

             var task = new Tasks()
             {

                 NameTask = model.NameTask,
                 DueDate = model.DueDate,
             };
           


       

           _appDbContext.Tasks.Add(task);
            _appDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
    }

}
    }





