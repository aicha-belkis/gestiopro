using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GestionProject.Models
{
    public class TeamMember : BaseEntity
    {
        public TeamMember()
        {
            TeamMemberProjects = new Collection<TeamMemberProject>();
        }
        public ICollection<TeamMemberProject> TeamMemberProjects { get; set; }
    }
}

