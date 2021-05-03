namespace GestionProject.Models
{
    public class TeamMemberProject
    {
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }



        public int ProjectId { get; set; }
        public Project Project { get; set; }
        
        public int TaskID { get; set; }
        public Tasks Tasks { get; set; }
    }
}