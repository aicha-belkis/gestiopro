using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GestionProject.Models
{
    public class Client : BaseEntity
    { 
   public Client()
    {
        Projects = new Collection<Project>();
    }

    public string Company { get; set; }

    public string City { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public ICollection<Project> Projects { get; set; }

      
    

    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}
}
