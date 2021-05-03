

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace GestionProject.Models
{
    public class Project : BaseEntity
    { 
        public Project()

    {
        ProjectTeamMembers = new Collection<TeamMemberProject>();
    }

    public string Projectname { get; set; }
        public string Projectmanager { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndDate { get; set; }

      


        public int MangerId { get; set; }
        public Manager Manager { get; set; }

        public int ClientId { get; set; }
    public Client Client { get; set; }
    
    public ICollection<TeamMemberProject> ProjectTeamMembers { get; set; }
}
}