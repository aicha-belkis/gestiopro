using GestionProject.Configurations;
using GestionProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionProject.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TeamMemberProject>()
               .HasKey(tmp => new { tmp.TeamMemberId, tmp.ProjectId });
            builder.Entity<TeamMemberProject>()
               .HasOne(tmp => tmp.Project)
               .WithMany(p => p.ProjectTeamMembers)
               .HasForeignKey(t => t.ProjectId);
            builder.Entity<TeamMemberProject>()
                .HasOne(tmp => tmp.TeamMember)
                .WithMany(p => p.TeamMemberProjects)
                .HasForeignKey(t => t.TeamMemberId);
            

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new ManagerConfiguration());
            builder.ApplyConfiguration(new UserWithRoleConfiguration());
        }
    }
}
