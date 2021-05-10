using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.ViewModels
{
    public class TeamMemberViewModel
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public DateTime Date{ get; set; }
        public string Email { get; set; }
        public string Group { get; set; }
        public double  Price{ get; set; }
        public string Password { get; set; }
		
	}
}
