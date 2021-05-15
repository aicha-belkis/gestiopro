using GestionProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.ViewModels
{
   


    public class ManagerSelectList
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }

    }
    public class ClientSelectList
    {
        public int ClientId { get; set; }
        public string ClientNames { get; set; }

    }

   public class TeamMemberlist
    {
        public int TeamMemberId { get; set; }
        public string  Group { get; set; }

    }
    
    public class ProjectViewModel
       
    {
        public ProjectViewModel()
		{
            TeamMemberlist = new List<SelectListItem>();
            TeamMemberId = new List<int>();
		}

        public List<SelectListItem> TeamMemberlist { get; set; }
        public string stringTeam { get; set; }
        public List<int> TeamMemberId { get; set; }

        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string ManagerName { get; set; }

        public List<ClientSelectList> Clients { get;set; }
        public int ClientId { get; set; }

        


        public List<ManagerSelectList> Managers { get; set; }
        public int ManagerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public string ProjectManager { get; set; }
        public string Teams { get; set; }

        


    }
}
