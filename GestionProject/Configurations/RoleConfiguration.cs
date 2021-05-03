using GestionProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>

    {
        private readonly string _managerRoleId;
        private readonly string _clientRoleId;
        private readonly string _teamMemberRole;
        public RoleConfiguration()
        {
            _managerRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
            _clientRoleId = Guid.NewGuid().ToString();
            _teamMemberRole = Guid.NewGuid().ToString();
        }


        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = _managerRoleId,
                   Name = AppUserRoles.Manager,
                   NormalizedName = AppUserRoles.Manager.ToUpperInvariant()
               },
                new IdentityRole
                {
                    Id = _clientRoleId,
                    Name = AppUserRoles.Client,
                    NormalizedName = AppUserRoles.Client.ToUpperInvariant()
                },
                new IdentityRole
                {
                    Id = _teamMemberRole,
                    Name = AppUserRoles.TeamMember,
                    NormalizedName = AppUserRoles.TeamMember.ToUpperInvariant()
                }
               );
        }
    }
}

