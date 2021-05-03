using GestionProject.Data;
using GestionProject.Models;

using GestionProject.ViewModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Controllers
{
    public class ClientController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _appDbContext;

        public ClientController(UserManager<AppUser> userManager, AppDbContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var clients = _appDbContext.Clients
                .Include(x => x.Projects)
                .Include(x => x.AppUser)
                .ToList();

            List<ClientViewModel> model = new();

            foreach (var client in clients)
            {
                model.Add(new ClientViewModel
                {
                    City = client.City,
                    Company = client.Company,
                    Email = client.Email,
                    Phone = client.Phone,
                    ProjectName = client.Projects.First().Projectname,
                    Username = client.AppUser.UserName
                });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ClientViewModel model = new();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClientViewModel model)
        {

            //register user
            AppUser appUser = new AppUser
            {
                Email = model.Email,
                Firstname = model.Username,
                Lastname = model.Username,
                UserName = model.Username,
                PhoneNumber = model.Phone,
                PhoneNumberConfirmed = true,
                Role = AppUserRoles.Client
            };

            appUser.PasswordHash = new PasswordHasher<AppUser>().HashPassword(appUser, "client@password.com");
            var registrationResult = await _userManager.CreateAsync(appUser);
            if (!registrationResult.Succeeded)
                return View();

            //Add user to client role
            appUser = await _userManager.FindByNameAsync(model.Username);
            await _userManager.AddToRoleAsync(appUser, AppUserRoles.Client);

            //Register client
            Client client = new()
            {
                CreationDate = DateTime.Now,
                AppUserId = appUser.Id,
                City = model.City,
                Company = model.Company,
                Email = model.Email,
                Phone = model.Phone
            };

            //Add project to client
            client.Projects.Add(new Project
            {
                CreationDate = DateTime.Now,
                Projectname = model.ProjectName
            });

            _appDbContext.Clients.Add(client);
            _appDbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
