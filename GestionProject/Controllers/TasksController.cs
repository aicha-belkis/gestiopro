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

        public IActionResult Index()

        {

            var model = new List<TaskViewModel>();
            var tasks = _appDbContext.Tasks.Include(x => x.ProjectTeamMembers).ToList();

            foreach (var task  in tasks)
			{
                model.Add(new TaskViewModel{

                            Teams = task.Group,
                            NameTask = task.NameTask,
                            DueDate = task.DueDate,

                        });
			}
            return View(model);

            


          
        }

          
        

        [HttpGet]
        public IActionResult Create()
        {

             Tasks task = new Tasks();
          
                return PartialView("_Add", task);
             }
        [HttpPost]
        public IActionResult Create(Tasks task)
        {
            _appDbContext.Tasks.Add(task);
            return PartialView("_Add", task);
        }

        public IActionResult Delete([FromQuery]int? id)
        {

            var task = _appDbContext.Tasks.Find(id);
            if (task == null)
            {

                return View();
            }


            _appDbContext.Tasks.Remove(task);
            _appDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}



     //   [HttpPost]
     //   public IActionResult Update(int? id)
      //  {

          
         //   if (id==null || id ==0)
		//	{
            //    return NotFound();
		//	}
          //  var task= _appDbContext.Tasks.Find(id);
          //  if (task == null)
		//	{
            //    return NotFound();
		//	}

          //  return View(task);

   





