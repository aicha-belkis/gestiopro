using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.ViewModels
{
    public class ProjectViewModel
    {
        public string ProjectName { get; set; }

        public string ClientNames { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public string ProjectManager { get; set; }
        public string Team { get; set; }

       
    }
}
