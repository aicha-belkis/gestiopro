using GestionProject.Models;
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

   public class TeamMemberSelectList
    {
        public int TeamMemberId { get; set; }
        public string  Group { get; set; }

    }
    
    public class ProjectViewModel
    {
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string ManagerName { get; set; }

        public List<ClientSelectList> Clients { get;set; }
        public int ClientId { get; set; }

        public List<TeamMemberSelectList> TeamMembers { get; set; }
        public int TeamMemberId { get; set; }


        public List<ManagerSelectList> Managers { get; set; }
        public int ManagerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public string ProjectManager { get; set; }
        public string Teams { get; set; }

        


    }
}
